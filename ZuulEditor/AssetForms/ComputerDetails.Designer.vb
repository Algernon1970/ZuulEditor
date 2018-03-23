<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComputerDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ComputerInfoList = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.CreateComputerButton = New System.Windows.Forms.Button()
        Me.SaveComputerButton = New System.Windows.Forms.Button()
        Me.DeleteComputerButton = New System.Windows.Forms.Button()
        Me.ShowDisposedButton = New System.Windows.Forms.CheckBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FilterLabel = New System.Windows.Forms.Label()
        Me.FilterBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.InventoryBox = New System.Windows.Forms.TextBox()
        Me.SerialNumberBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DisposedTick = New System.Windows.Forms.CheckBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.PurchaseCostBox = New System.Windows.Forms.TextBox()
        Me.PurchaseDateBox = New System.Windows.Forms.TextBox()
        Me.SupplierCombo = New System.Windows.Forms.ComboBox()
        Me.TblSupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ZuulDataSet = New ZuulEditor.ZuulDataSet()
        Me.MakeLabel = New System.Windows.Forms.Label()
        Me.LocationCombo = New System.Windows.Forms.ComboBox()
        Me.TblLocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModelLabel = New System.Windows.Forms.Label()
        Me.RamBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComputerListBox = New System.Windows.Forms.ListBox()
        Me.TblComputerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SearchInv = New System.Windows.Forms.CheckBox()
        Me.SearchSerial = New System.Windows.Forms.CheckBox()
        Me.SearchMake = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.WirelessMACBox = New System.Windows.Forms.TextBox()
        Me.WiredMACBox = New System.Windows.Forms.TextBox()
        Me.SSDBox = New System.Windows.Forms.CheckBox()
        Me.HDDBox = New System.Windows.Forms.TextBox()
        Me.HDDLabel = New System.Windows.Forms.Label()
        Me.RamLabel = New System.Windows.Forms.Label()
        Me.ModelBox = New System.Windows.Forms.TextBox()
        Me.LocationLabel = New System.Windows.Forms.Label()
        Me.MakeBox = New System.Windows.Forms.TextBox()
        Me.SupplierLabel = New System.Windows.Forms.Label()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.PurchaseDateLabel = New System.Windows.Forms.Label()
        Me.PurchaseCostLabel = New System.Windows.Forms.Label()
        Me.Tbl_ComputerTableAdapter = New ZuulEditor.ZuulDataSetTableAdapters.Tbl_ComputerTableAdapter()
        Me.Tbl_LocationTableAdapter = New ZuulEditor.ZuulDataSetTableAdapters.Tbl_LocationTableAdapter()
        Me.Tbl_SupplierTableAdapter = New ZuulEditor.ZuulDataSetTableAdapters.Tbl_SupplierTableAdapter()
        Me.Lnk_ComputerInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Lnk_ComputerInfoTableAdapter = New ZuulEditor.ZuulDataSetTableAdapters.Lnk_ComputerInfoTableAdapter()
        Me.TableAdapterManager = New ZuulEditor.ZuulDataSetTableAdapters.TableAdapterManager()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.ComputerInfoList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZuulDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblLocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.TblComputerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.Lnk_ComputerInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.ComputerInfoList, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(724, 266)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'ComputerInfoList
        '
        Me.ComputerInfoList.AllowUserToAddRows = False
        Me.ComputerInfoList.AllowUserToDeleteRows = False
        Me.ComputerInfoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ComputerInfoList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComputerInfoList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.ComputerInfoList.Location = New System.Drawing.Point(3, 3)
        Me.ComputerInfoList.Name = "ComputerInfoList"
        Me.ComputerInfoList.Size = New System.Drawing.Size(587, 260)
        Me.ComputerInfoList.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(596, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(125, 260)
        Me.Panel2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.Location = New System.Drawing.Point(0, 237)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add Note"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoScroll = True
        Me.TableLayoutPanel3.ColumnCount = 5
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel3, 2)
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 231.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 231.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.CreateComputerButton, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.SaveComputerButton, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.DeleteComputerButton, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.ShowDisposedButton, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.FlowLayoutPanel1, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 520)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(921, 29)
        Me.TableLayoutPanel3.TabIndex = 4
        '
        'CreateComputerButton
        '
        Me.CreateComputerButton.Location = New System.Drawing.Point(3, 3)
        Me.CreateComputerButton.Name = "CreateComputerButton"
        Me.CreateComputerButton.Size = New System.Drawing.Size(107, 23)
        Me.CreateComputerButton.TabIndex = 6
        Me.CreateComputerButton.Text = "Create Computer"
        Me.CreateComputerButton.UseVisualStyleBackColor = True
        '
        'SaveComputerButton
        '
        Me.SaveComputerButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveComputerButton.Enabled = False
        Me.SaveComputerButton.Location = New System.Drawing.Point(792, 3)
        Me.SaveComputerButton.Name = "SaveComputerButton"
        Me.SaveComputerButton.Size = New System.Drawing.Size(126, 23)
        Me.SaveComputerButton.TabIndex = 8
        Me.SaveComputerButton.Text = "Save Computer Details"
        Me.SaveComputerButton.UseVisualStyleBackColor = True
        '
        'DeleteComputerButton
        '
        Me.DeleteComputerButton.Location = New System.Drawing.Point(558, 3)
        Me.DeleteComputerButton.Name = "DeleteComputerButton"
        Me.DeleteComputerButton.Size = New System.Drawing.Size(91, 23)
        Me.DeleteComputerButton.TabIndex = 9
        Me.DeleteComputerButton.Text = "Delete Computer"
        Me.DeleteComputerButton.UseVisualStyleBackColor = True
        '
        'ShowDisposedButton
        '
        Me.ShowDisposedButton.AutoSize = True
        Me.ShowDisposedButton.Location = New System.Drawing.Point(353, 3)
        Me.ShowDisposedButton.Name = "ShowDisposedButton"
        Me.ShowDisposedButton.Size = New System.Drawing.Size(100, 17)
        Me.ShowDisposedButton.TabIndex = 7
        Me.ShowDisposedButton.Text = "Show Disposed"
        Me.ShowDisposedButton.ThreeState = True
        Me.ShowDisposedButton.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.FilterLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.FilterBox)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(122, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(225, 23)
        Me.FlowLayoutPanel1.TabIndex = 10
        '
        'FilterLabel
        '
        Me.FilterLabel.AutoSize = True
        Me.FilterLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FilterLabel.Location = New System.Drawing.Point(3, 0)
        Me.FilterLabel.Name = "FilterLabel"
        Me.FilterLabel.Size = New System.Drawing.Size(29, 26)
        Me.FilterLabel.TabIndex = 0
        Me.FilterLabel.Text = "Filter"
        Me.FilterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FilterBox
        '
        Me.FilterBox.Location = New System.Drawing.Point(38, 3)
        Me.FilterBox.Name = "FilterBox"
        Me.FilterBox.Size = New System.Drawing.Size(134, 20)
        Me.FilterBox.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ZuulEditor.My.Resources.Resources.Computer
        Me.PictureBox1.Location = New System.Drawing.Point(315, 75)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'InventoryBox
        '
        Me.InventoryBox.Location = New System.Drawing.Point(422, 35)
        Me.InventoryBox.Name = "InventoryBox"
        Me.InventoryBox.Size = New System.Drawing.Size(100, 20)
        Me.InventoryBox.TabIndex = 22
        '
        'SerialNumberBox
        '
        Me.SerialNumberBox.Location = New System.Drawing.Point(422, 9)
        Me.SerialNumberBox.Name = "SerialNumberBox"
        Me.SerialNumberBox.Size = New System.Drawing.Size(100, 20)
        Me.SerialNumberBox.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(346, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "InventoryTag"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(343, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Serial Number"
        '
        'DisposedTick
        '
        Me.DisposedTick.AutoSize = True
        Me.DisposedTick.Location = New System.Drawing.Point(626, 19)
        Me.DisposedTick.Name = "DisposedTick"
        Me.DisposedTick.Size = New System.Drawing.Size(70, 17)
        Me.DisposedTick.TabIndex = 18
        Me.DisposedTick.Text = "Disposed"
        Me.DisposedTick.UseVisualStyleBackColor = True
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(3, 12)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(35, 13)
        Me.NameLabel.TabIndex = 9
        Me.NameLabel.Text = "Name"
        '
        'PurchaseCostBox
        '
        Me.PurchaseCostBox.Location = New System.Drawing.Point(596, 144)
        Me.PurchaseCostBox.Name = "PurchaseCostBox"
        Me.PurchaseCostBox.Size = New System.Drawing.Size(100, 20)
        Me.PurchaseCostBox.TabIndex = 17
        '
        'PurchaseDateBox
        '
        Me.PurchaseDateBox.Location = New System.Drawing.Point(596, 118)
        Me.PurchaseDateBox.Name = "PurchaseDateBox"
        Me.PurchaseDateBox.Size = New System.Drawing.Size(100, 20)
        Me.PurchaseDateBox.TabIndex = 16
        '
        'SupplierCombo
        '
        Me.SupplierCombo.DataSource = Me.TblSupplierBindingSource
        Me.SupplierCombo.DisplayMember = "Name"
        Me.SupplierCombo.FormattingEnabled = True
        Me.SupplierCombo.Location = New System.Drawing.Point(596, 167)
        Me.SupplierCombo.Name = "SupplierCombo"
        Me.SupplierCombo.Size = New System.Drawing.Size(121, 21)
        Me.SupplierCombo.TabIndex = 15
        '
        'TblSupplierBindingSource
        '
        Me.TblSupplierBindingSource.DataMember = "Tbl_Supplier"
        Me.TblSupplierBindingSource.DataSource = Me.ZuulDataSet
        '
        'ZuulDataSet
        '
        Me.ZuulDataSet.DataSetName = "ZuulDataSet"
        Me.ZuulDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MakeLabel
        '
        Me.MakeLabel.AutoSize = True
        Me.MakeLabel.Location = New System.Drawing.Point(4, 64)
        Me.MakeLabel.Name = "MakeLabel"
        Me.MakeLabel.Size = New System.Drawing.Size(34, 13)
        Me.MakeLabel.TabIndex = 2
        Me.MakeLabel.Text = "Make"
        '
        'LocationCombo
        '
        Me.LocationCombo.DataSource = Me.TblLocationBindingSource
        Me.LocationCombo.DisplayMember = "LocationName"
        Me.LocationCombo.FormattingEnabled = True
        Me.LocationCombo.Location = New System.Drawing.Point(58, 162)
        Me.LocationCombo.Name = "LocationCombo"
        Me.LocationCombo.Size = New System.Drawing.Size(155, 21)
        Me.LocationCombo.TabIndex = 14
        '
        'TblLocationBindingSource
        '
        Me.TblLocationBindingSource.DataMember = "Tbl_Location"
        Me.TblLocationBindingSource.DataSource = Me.ZuulDataSet
        '
        'ModelLabel
        '
        Me.ModelLabel.AutoSize = True
        Me.ModelLabel.Location = New System.Drawing.Point(4, 90)
        Me.ModelLabel.Name = "ModelLabel"
        Me.ModelLabel.Size = New System.Drawing.Size(36, 13)
        Me.ModelLabel.TabIndex = 3
        Me.ModelLabel.Text = "Model"
        '
        'RamBox
        '
        Me.RamBox.Location = New System.Drawing.Point(58, 114)
        Me.RamBox.Name = "RamBox"
        Me.RamBox.Size = New System.Drawing.Size(51, 20)
        Me.RamBox.TabIndex = 13
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.0356!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.9644!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ComputerListBox, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(927, 552)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Computers"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(198, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(726, 35)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Detail"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComputerListBox
        '
        Me.ComputerListBox.DataSource = Me.TblComputerBindingSource
        Me.ComputerListBox.DisplayMember = "Name"
        Me.ComputerListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComputerListBox.FormattingEnabled = True
        Me.ComputerListBox.Location = New System.Drawing.Point(3, 38)
        Me.ComputerListBox.Name = "ComputerListBox"
        Me.ComputerListBox.Size = New System.Drawing.Size(189, 476)
        Me.ComputerListBox.Sorted = True
        Me.ComputerListBox.TabIndex = 2
        '
        'TblComputerBindingSource
        '
        Me.TblComputerBindingSource.DataMember = "Tbl_Computer"
        Me.TblComputerBindingSource.DataSource = Me.ZuulDataSet
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SplitContainer1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(198, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(726, 476)
        Me.Panel1.TabIndex = 3
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.CheckBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SearchInv)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SearchSerial)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SearchMake)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.WirelessMACBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.WiredMACBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SSDBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.HDDBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.HDDLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.InventoryBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SerialNumberBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DisposedTick)
        Me.SplitContainer1.Panel1.Controls.Add(Me.NameLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PurchaseCostBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PurchaseDateBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SupplierCombo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MakeLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LocationCombo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ModelLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RamBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RamLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ModelBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LocationLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MakeBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SupplierLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.NameBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PurchaseDateLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PurchaseCostLabel)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(726, 476)
        Me.SplitContainer1.SplitterDistance = 204
        Me.SplitContainer1.TabIndex = 18
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(164, 89)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(60, 17)
        Me.CheckBox1.TabIndex = 34
        Me.CheckBox1.Text = "Search"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'SearchInv
        '
        Me.SearchInv.AutoSize = True
        Me.SearchInv.Location = New System.Drawing.Point(528, 37)
        Me.SearchInv.Name = "SearchInv"
        Me.SearchInv.Size = New System.Drawing.Size(60, 17)
        Me.SearchInv.TabIndex = 33
        Me.SearchInv.Text = "Search"
        Me.SearchInv.UseVisualStyleBackColor = True
        '
        'SearchSerial
        '
        Me.SearchSerial.AutoSize = True
        Me.SearchSerial.Location = New System.Drawing.Point(528, 11)
        Me.SearchSerial.Name = "SearchSerial"
        Me.SearchSerial.Size = New System.Drawing.Size(60, 17)
        Me.SearchSerial.TabIndex = 32
        Me.SearchSerial.Text = "Search"
        Me.SearchSerial.UseVisualStyleBackColor = True
        '
        'SearchMake
        '
        Me.SearchMake.AutoSize = True
        Me.SearchMake.Location = New System.Drawing.Point(164, 63)
        Me.SearchMake.Name = "SearchMake"
        Me.SearchMake.Size = New System.Drawing.Size(60, 17)
        Me.SearchMake.TabIndex = 31
        Me.SearchMake.Text = "Search"
        Me.SearchMake.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(529, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Wired MAC"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(517, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Wireless MAC"
        '
        'WirelessMACBox
        '
        Me.WirelessMACBox.Location = New System.Drawing.Point(596, 87)
        Me.WirelessMACBox.Name = "WirelessMACBox"
        Me.WirelessMACBox.Size = New System.Drawing.Size(120, 20)
        Me.WirelessMACBox.TabIndex = 30
        '
        'WiredMACBox
        '
        Me.WiredMACBox.Location = New System.Drawing.Point(596, 61)
        Me.WiredMACBox.Name = "WiredMACBox"
        Me.WiredMACBox.Size = New System.Drawing.Size(120, 20)
        Me.WiredMACBox.TabIndex = 29
        '
        'SSDBox
        '
        Me.SSDBox.AutoSize = True
        Me.SSDBox.Location = New System.Drawing.Point(246, 116)
        Me.SSDBox.Name = "SSDBox"
        Me.SSDBox.Size = New System.Drawing.Size(48, 17)
        Me.SSDBox.TabIndex = 26
        Me.SSDBox.Text = "SSD"
        Me.SSDBox.UseVisualStyleBackColor = True
        '
        'HDDBox
        '
        Me.HDDBox.Location = New System.Drawing.Point(189, 114)
        Me.HDDBox.Name = "HDDBox"
        Me.HDDBox.Size = New System.Drawing.Size(51, 20)
        Me.HDDBox.TabIndex = 25
        '
        'HDDLabel
        '
        Me.HDDLabel.AutoSize = True
        Me.HDDLabel.Location = New System.Drawing.Point(152, 117)
        Me.HDDLabel.Name = "HDDLabel"
        Me.HDDLabel.Size = New System.Drawing.Size(31, 13)
        Me.HDDLabel.TabIndex = 24
        Me.HDDLabel.Text = "HDD"
        '
        'RamLabel
        '
        Me.RamLabel.AutoSize = True
        Me.RamLabel.Location = New System.Drawing.Point(4, 117)
        Me.RamLabel.Name = "RamLabel"
        Me.RamLabel.Size = New System.Drawing.Size(29, 13)
        Me.RamLabel.TabIndex = 4
        Me.RamLabel.Text = "Ram"
        '
        'ModelBox
        '
        Me.ModelBox.Location = New System.Drawing.Point(58, 87)
        Me.ModelBox.Name = "ModelBox"
        Me.ModelBox.Size = New System.Drawing.Size(100, 20)
        Me.ModelBox.TabIndex = 12
        '
        'LocationLabel
        '
        Me.LocationLabel.AutoSize = True
        Me.LocationLabel.Location = New System.Drawing.Point(4, 165)
        Me.LocationLabel.Name = "LocationLabel"
        Me.LocationLabel.Size = New System.Drawing.Size(48, 13)
        Me.LocationLabel.TabIndex = 5
        Me.LocationLabel.Text = "Location"
        '
        'MakeBox
        '
        Me.MakeBox.Location = New System.Drawing.Point(58, 61)
        Me.MakeBox.Name = "MakeBox"
        Me.MakeBox.Size = New System.Drawing.Size(100, 20)
        Me.MakeBox.TabIndex = 11
        '
        'SupplierLabel
        '
        Me.SupplierLabel.AutoSize = True
        Me.SupplierLabel.Location = New System.Drawing.Point(545, 170)
        Me.SupplierLabel.Name = "SupplierLabel"
        Me.SupplierLabel.Size = New System.Drawing.Size(45, 13)
        Me.SupplierLabel.TabIndex = 6
        Me.SupplierLabel.Text = "Supplier"
        '
        'NameBox
        '
        Me.NameBox.Location = New System.Drawing.Point(58, 9)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(100, 20)
        Me.NameBox.TabIndex = 10
        '
        'PurchaseDateLabel
        '
        Me.PurchaseDateLabel.AutoSize = True
        Me.PurchaseDateLabel.Location = New System.Drawing.Point(512, 121)
        Me.PurchaseDateLabel.Name = "PurchaseDateLabel"
        Me.PurchaseDateLabel.Size = New System.Drawing.Size(78, 13)
        Me.PurchaseDateLabel.TabIndex = 7
        Me.PurchaseDateLabel.Text = "Purchase Date"
        '
        'PurchaseCostLabel
        '
        Me.PurchaseCostLabel.AutoSize = True
        Me.PurchaseCostLabel.Location = New System.Drawing.Point(514, 147)
        Me.PurchaseCostLabel.Name = "PurchaseCostLabel"
        Me.PurchaseCostLabel.Size = New System.Drawing.Size(76, 13)
        Me.PurchaseCostLabel.TabIndex = 8
        Me.PurchaseCostLabel.Text = "Purchase Cost"
        '
        'Tbl_ComputerTableAdapter
        '
        Me.Tbl_ComputerTableAdapter.ClearBeforeFill = True
        '
        'Tbl_LocationTableAdapter
        '
        Me.Tbl_LocationTableAdapter.ClearBeforeFill = True
        '
        'Tbl_SupplierTableAdapter
        '
        Me.Tbl_SupplierTableAdapter.ClearBeforeFill = True
        '
        'Lnk_ComputerInfoBindingSource
        '
        Me.Lnk_ComputerInfoBindingSource.DataMember = "Lnk_ComputerInfo"
        Me.Lnk_ComputerInfoBindingSource.DataSource = Me.ZuulDataSet
        '
        'Lnk_ComputerInfoTableAdapter
        '
        Me.Lnk_ComputerInfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Lnk_ComputerInfoTableAdapter = Me.Lnk_ComputerInfoTableAdapter
        Me.TableAdapterManager.Lnk_ComputerPersonTableAdapter = Nothing
        Me.TableAdapterManager.Lnk_ComputerPrinterTableAdapter = Nothing
        Me.TableAdapterManager.Lnk_PrinterInfoTableAdapter = Nothing
        Me.TableAdapterManager.Lnk_ProjectorInfoTableAdapter = Nothing
        Me.TableAdapterManager.Tbl_ComputerTableAdapter = Me.Tbl_ComputerTableAdapter
        Me.TableAdapterManager.Tbl_EquipmentTableAdapter = Nothing
        Me.TableAdapterManager.Tbl_FilesTableAdapter = Nothing
        Me.TableAdapterManager.Tbl_InfoTableAdapter = Nothing
        Me.TableAdapterManager.Tbl_LocationTableAdapter = Me.Tbl_LocationTableAdapter
        Me.TableAdapterManager.Tbl_PersonTableAdapter = Nothing
        Me.TableAdapterManager.Tbl_PrinterTableAdapter = Nothing
        Me.TableAdapterManager.Tbl_ProjectorTableAdapter = Nothing
        Me.TableAdapterManager.Tbl_SupplierTableAdapter = Me.Tbl_SupplierTableAdapter
        Me.TableAdapterManager.UpdateOrder = ZuulEditor.ZuulDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ComputerDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 552)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "ComputerDetails"
        Me.Text = "ComputerDetails"
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.ComputerInfoList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZuulDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblLocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.TblComputerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.Lnk_ComputerInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents ComputerInfoList As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComputerListBox As ListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents InventoryBox As TextBox
    Friend WithEvents SerialNumberBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DisposedTick As CheckBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents PurchaseCostBox As TextBox
    Friend WithEvents PurchaseDateBox As TextBox
    Friend WithEvents SupplierCombo As ComboBox
    Friend WithEvents MakeLabel As Label
    Friend WithEvents LocationCombo As ComboBox
    Friend WithEvents ModelLabel As Label
    Friend WithEvents RamBox As TextBox
    Friend WithEvents RamLabel As Label
    Friend WithEvents ModelBox As TextBox
    Friend WithEvents LocationLabel As Label
    Friend WithEvents MakeBox As TextBox
    Friend WithEvents SupplierLabel As Label
    Friend WithEvents NameBox As TextBox
    Friend WithEvents PurchaseDateLabel As Label
    Friend WithEvents PurchaseCostLabel As Label
    Friend WithEvents CreateComputerButton As Button
    Friend WithEvents ShowDisposedButton As CheckBox
    Friend WithEvents SaveComputerButton As Button
    Friend WithEvents DeleteComputerButton As Button
    Friend WithEvents ZuulDataSet As ZuulDataSet
    Friend WithEvents TblComputerBindingSource As BindingSource
    Friend WithEvents Tbl_ComputerTableAdapter As ZuulDataSetTableAdapters.Tbl_ComputerTableAdapter
    Friend WithEvents TblLocationBindingSource As BindingSource
    Friend WithEvents Tbl_LocationTableAdapter As ZuulDataSetTableAdapters.Tbl_LocationTableAdapter
    Friend WithEvents TblSupplierBindingSource As BindingSource
    Friend WithEvents Tbl_SupplierTableAdapter As ZuulDataSetTableAdapters.Tbl_SupplierTableAdapter
    Friend WithEvents Lnk_ComputerInfoBindingSource As BindingSource
    Friend WithEvents Lnk_ComputerInfoTableAdapter As ZuulDataSetTableAdapters.Lnk_ComputerInfoTableAdapter
    Friend WithEvents TableAdapterManager As ZuulDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents WirelessMACBox As TextBox
    Friend WithEvents WiredMACBox As TextBox
    Friend WithEvents SSDBox As CheckBox
    Friend WithEvents HDDBox As TextBox
    Friend WithEvents HDDLabel As Label
    Friend WithEvents SearchInv As CheckBox
    Friend WithEvents SearchSerial As CheckBox
    Friend WithEvents SearchMake As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FilterLabel As Label
    Friend WithEvents FilterBox As TextBox
End Class
