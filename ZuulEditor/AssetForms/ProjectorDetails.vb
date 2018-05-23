Imports System.ComponentModel

Public Class ProjectorDetails
    Dim defaultPid As Integer = 0
    Dim bg As New BackgroundWorker
    Dim currentProjectorRow As DataRow
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
        SaveProjectorButton.Enabled = True
    End Sub

    Private Sub ProjectorDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Tbl_LocationTableAdapter.Fill(Me.ZuulDataSet.Tbl_Location)
        Me.Tbl_SupplierTableAdapter.Fill(Me.ZuulDataSet.Tbl_Supplier)
        Me.Tbl_ProjectorTableAdapter.Fill(Me.ZuulDataSet.Tbl_Projector)
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

    Private Sub ProjectorListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProjectorListBox.SelectedIndexChanged
        If ProjectorListBox.SelectedIndex > -1 Then
            Try
                Dim projectorrow As DataRow = GetSelectedProjector()
                defaultPid = projectorrow.Field(Of Integer)("ProjectID")
                DisplayProjector(projectorrow)
                DisplayNotesForProjector(projectorrow)

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
        Dim LocationNumber As Integer = projectorrow.Field(Of Integer)("Location")
        Dim SupplierNumber As Integer = projectorrow.Field(Of Integer)("Supplier")
        PurchaseDateBox.Text = projectorrow.Field(Of Date)("PurchaseDate").ToShortDateString
        PurchaseCostBox.Text = projectorrow.Field(Of Decimal)("PurchaseCost").ToString("£0.00")
        Dim LocationName As String = LocationTableAdapter.GetLocationName(LocationNumber).Rows(0).Field(Of String)("LocationName")
        LocationCombo.SelectedIndex = LocationCombo.FindString(LocationName)
        Dim SupplierName As String = Tbl_SupplierTableAdapter.GetSupplierName(SupplierNumber).Rows(0).Field(Of String)("Name")
        SupplierCombo.SelectedIndex = SupplierCombo.FindString(SupplierName)
        If DisposedTick.Checked Then
            PictureBox1.Image = My.Resources.DisposedProjector
        Else
            PictureBox1.Image = My.Resources.Projector
        End If
        InventoryBox.Text = projectorrow.Field(Of String)("InventoryNumber")
        SerialNumberBox.Text = projectorrow.Field(Of String)("SerialNumber")
        SaveProjectorButton.Enabled = False

    End Sub

    Private Sub DisplayNotesForProjector(ByVal printerrow As DataRow)
        Dim Lnk_ProjectorInfoTableAdapter As New ZuulDataSetTableAdapters.Lnk_ProjectorInfoTableAdapter
        Dim infotable As DataTable = Lnk_ProjectorInfoTableAdapter.GetInfoByPID(printerrow.Field(Of Integer)("PrinterID"))
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
        PurchaseDateBox.Text = ""
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
End Class