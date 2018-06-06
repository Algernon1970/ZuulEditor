Imports System.ComponentModel

Public Class ProjectorDetails
    Dim defaultPid As Integer = 0
    Dim bg As New BackgroundWorker
    Dim currentProjectorRow As DataRow
    Dim searchMode As SearchField
    'Dim lastkey As Keys = Keys.A

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
        SaveProjectorButton.Enabled = True
    End Sub

    Private Sub ProjectorDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Tbl_LocationTableAdapter.Fill(Me.ZuulDataSet.Tbl_Location)
        Me.Tbl_SupplierTableAdapter.Fill(Me.ZuulDataSet.Tbl_Supplier)
        Me.Tbl_ProjectorTableAdapter.Fill(Me.ZuulDataSet.Tbl_Projector)
        Me.TblProjectorBindingSource.Filter = "disposed = false"
        ShowDisposedButton.Text = "Showing Active"
        AddHandlers()
    End Sub

    Public Function SelectProjectorByName(ByVal projectorName As String) As Boolean
        Dim index As Integer = ProjectorListBox.FindString(projectorName)
        If index > -1 Then
            ProjectorListBox.SetSelected(index, True)
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub SelectByIndex(ByVal index As Integer)
        ProjectorListBox.SelectedIndex = index
    End Sub

    Private Sub ProjectorListBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles ProjectorListBox.SelectedValueChanged
        If ProjectorListBox.SelectedIndex > -1 Then
            Try
                Dim projectorrow As DataRow = GetSelectedProjector()
                defaultPid = projectorrow.Field(Of Integer)("ProjectID")
                DisplayProjector(projectorrow)
                ' DisplayNotesForProjector(projectorrow)

            Catch ex As Exception
                ClearDisplay()
                SelectByIndex(-1)
            End Try
        Else
            ClearDisplay()
        End If
    End Sub

    Private Function GetSelectedProjector() As DataRow
        Dim projectorrow As DataRow = Nothing
        If ProjectorListBox.SelectedItems.Count = 1 Then
            projectorrow = DirectCast(ProjectorListBox.SelectedItem, DataRowView).Row
        Else
            Try
                projectorrow = Tbl_ProjectorTableAdapter.GetProjectorByProjectorID(defaultPid)(0)
            Catch ex As Exception
                ProjectorListBox.SelectedIndex = 1
                projectorrow = DirectCast(ProjectorListBox.SelectedItem, DataRowView).Row

            End Try
        End If
        Return projectorrow
    End Function

    Private Sub DisplayProjector(ByVal projectorrow As DataRow)
        currentProjectorRow = projectorrow
        Dim LocationTableAdapter As New ZuulDataSetTableAdapters.Tbl_LocationTableAdapter
        Dim SupplierTableAdapter As New ZuulDataSetTableAdapters.Tbl_SupplierTableAdapter
        NameBox.Text = projectorrow.Field(Of String)("Name")
        MakeBox.Text = projectorrow.Field(Of String)("Make")
        ModelBox.Text = projectorrow.Field(Of String)("Model")
        LastCleanedBox.Text = projectorrow.Field(Of Date)("LastCleaned").ToShortDateString
        Dim LocationNumber As Integer = projectorrow.Field(Of Integer)("Location")
        Dim SupplierNumber As Integer = projectorrow.Field(Of Integer)("Supplier")
        PurchaseDateBox1.Text = projectorrow.Field(Of Date)("PurchaseDate").ToShortDateString
        PurchaseCostBox.Text = projectorrow.Field(Of Decimal)("PurchaseCost").ToString("£0.00")
        Dim LocationName As String = LocationTableAdapter.GetLocationName(LocationNumber).Rows(0).Field(Of String)("LocationName")
        LocationCombo.SelectedIndex = LocationCombo.FindString(LocationName)
        Dim SupplierName As String = Tbl_SupplierTableAdapter.GetSupplierName(SupplierNumber).Rows(0).Field(Of String)("Name")
        SupplierCombo.SelectedIndex = SupplierCombo.FindString(SupplierName)
        DisposedTick.Checked = projectorrow.Field(Of Boolean)("Disposed")
        If DisposedTick.Checked Then
            PictureBox1.Image = My.Resources.DisposedProjector
        Else
            If Date.Parse(LastCleanedBox.Text) < Now.AddMonths(-3) Then
                LastCleanedBox.BackColor = Color.Yellow
                PictureBox1.Image = My.Resources.DirtyProjector
            Else
                LastCleanedBox.BackColor = Color.White
                PictureBox1.Image = My.Resources.Projector
            End If
        End If
        InventoryBox.Text = projectorrow.Field(Of String)("InventoryNumber")
        SerialNumberBox.Text = projectorrow.Field(Of String)("SerialNumber")
        SaveProjectorButton.Enabled = False
    End Sub

    Private Sub DisplayNotesForProjector(ByVal projectorrow As DataRow)
        Dim Lnk_ProjectorInfoTableAdapter As New ZuulDataSetTableAdapters.Lnk_ProjectorInfoTableAdapter
        Dim infotable As DataTable = Lnk_ProjectorInfoTableAdapter.GetInfoByPID(projectorrow.Field(Of Integer)("ProjectID"))
        ProjectorInfoList.DataSource = New DataView(infotable)

        For x As Integer = 0 To ProjectorInfoList.Columns.GetColumnCount(DataGridViewElementStates.Visible) - 1
            ProjectorInfoList.Columns(x).Visible = False
        Next
        ProjectorInfoList.Columns("Datestamp").Visible = True
        ProjectorInfoList.Columns("Title").Visible = True
    End Sub

    Private Sub ClearDisplay()
        Dim ProjectorTableAdapter As New ZuulDataSetTableAdapters.Tbl_ProjectorTableAdapter
        NameBox.Text = ""
        MakeBox.Text = ""
        ModelBox.Text = ""
        SerialNumberBox.Text = ""
        InventoryBox.Text = ""
        PurchaseCostBox.Text = ""
        PurchaseDateBox1.Text = ""
        LastCleanedBox.Text = ""
        DisposedTick.Checked = False
        Try
            SupplierCombo.SelectedIndex = 1
        Catch ex As Exception

        End Try
        Try
            LocationCombo.SelectedIndex = 1
        Catch ex As Exception

        End Try
        SaveProjectorButton.Enabled = False
        PictureBox1.Image = My.Resources.Projector
    End Sub

    Private Sub CreatePrinterButton_Click(sender As Object, e As EventArgs) Handles CreateProjectorButton.Click
        Dim req As New RequestString("Name", "New Projector", 300)
        Dim res As DialogResult = req.ShowDialog
        If res.Equals(DialogResult.OK) Then
            CreatePrinter(req.ResultTextBox.Text)
            ProjectorListBox.SelectedIndex = -1
            Me.Tbl_PrinterTableAdapter.Fill(Me.ZuulDataSet.Tbl_Printer)
            SelectProjectorByName(req.ResultTextBox.Text)
        End If
        req.Dispose()
    End Sub

    Private Sub CreatePrinter(ByVal name As String)
        If Tbl_PrinterTableAdapter.alreadyExists(name) > 0 Then
            MsgBox("A projector with that name already exists")
        Else
            Dim todaysDate As Date = Now().Date
            Tbl_ProjectorTableAdapter.Insert(name, "", "", 1, 1, todaysDate, 0, False, Date.Parse("1/1/1970"), "", "")
            SelectProjectorByName(Tbl_ProjectorTableAdapter.GetProjectorByName(name).Rows(0).Field(Of String)("Name"))
        End If
    End Sub

    Private Sub SaveProjectorButton_Click(sender As Object, e As EventArgs) Handles SaveProjectorButton.Click
        Dim name As String = NameBox.Text
        Dim make As String = MakeBox.Text
        Dim model As String = ModelBox.Text
        Dim serial As String = SerialNumberBox.Text
        Dim inventory As String = InventoryBox.Text
        Dim purchaseDate As String = "1/1/1970"
        Dim lastCleanDate As String = "1/1/1970"
        Dim testDate As Date
        If Date.TryParse(PurchaseDateBox1.Text, testDate) Then
            purchaseDate = PurchaseDateBox1.Text
        Else
            purchaseDate = "1/1/1970"
        End If
        If Date.TryParse(LastCleanedBox.Text, testDate) Then
            lastCleanDate = LastCleanedBox.Text
        Else
            lastCleanDate = "1/1/1970"
        End If
        Dim cost As Decimal = Decimal.Parse("0.0")
        Decimal.TryParse((PurchaseCostBox.Text.Replace("£", "")), cost)

        Dim disposed As Boolean = DisposedTick.Checked
        Dim loc As DataRow = DirectCast(LocationCombo.SelectedItem, DataRowView).Row
        Dim sup As DataRow = DirectCast(SupplierCombo.SelectedItem, DataRowView).Row
        SaveProjectorButton.Enabled = False
        Dim projectorrow As DataRow = GetSelectedProjector()
        Dim pid = projectorrow.Field(Of Integer)("ProjectID")
        Tbl_ProjectorTableAdapter.UpdateProjectorByID(name, model, loc.Field(Of Integer)("LocationID"), sup.Field(Of Integer)("SupplierID"), purchaseDate, cost, disposed, lastCleanDate, make, serial, inventory, pid)
        ProjectorListBox.SelectedIndex = -1
        Me.Tbl_ProjectorTableAdapter.Fill(Me.ZuulDataSet.Tbl_Projector)
        FillByDisposedButton()
        SelectProjectorByName(name)
    End Sub

    Private Sub FillByDisposedButton()
        If ShowDisposedButton.CheckState = CheckState.Checked Then
            Me.TblProjectorBindingSource.Filter = "disposed = true"
            ShowDisposedButton.Text = "Showing Disposed"
        ElseIf ShowDisposedButton.CheckState = CheckState.Unchecked Then
            Me.TblProjectorBindingSource.Filter = "disposed = false"
            ShowDisposedButton.Text = "Showing Active"
        ElseIf ShowDisposedButton.CheckState = CheckState.Indeterminate Then
            Me.TblProjectorBindingSource.Filter = ""
            ShowDisposedButton.Text = "Showing All"
        End If
    End Sub

    Private Sub ShowDisposedButton_CheckStateChanged(sender As Object, e As EventArgs) Handles ShowDisposedButton.CheckStateChanged
        FillByDisposedButton()
    End Sub

    Private Sub DisposedTick_CheckedChanged(sender As Object, e As EventArgs) Handles DisposedTick.CheckedChanged
        If DisposedTick.Checked Then
            If Not NameBox.Text.Contains("(") Then
                NameBox.Text = String.Format("{0}({1})", NameBox.Text, Now.ToShortDateString)
            End If
        Else
            NameBox.Text = NameBox.Text.Split("("c)(0)
        End If
    End Sub

    Private Sub LastCleanedButton_Click(sender As Object, e As EventArgs) Handles LastCleanedButton.Click
        LastCleanedBox.Text = Now.ToShortDateString
    End Sub
End Class