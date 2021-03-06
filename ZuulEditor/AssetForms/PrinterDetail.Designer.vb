﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrinterDetail
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PrinterListBox = New System.Windows.Forms.ListBox()
        Me.TblPrinterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ZuulDataSet = New ZuulEditor.ZuulDataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.UserSelectable = New System.Windows.Forms.CheckBox()
        Me.SearchModelRadio = New System.Windows.Forms.RadioButton()
        Me.SearchInvRadio = New System.Windows.Forms.RadioButton()
        Me.SearchSerialRadio = New System.Windows.Forms.RadioButton()
        Me.SearchMakeRadio = New System.Windows.Forms.RadioButton()
        Me.IPAddressButton = New System.Windows.Forms.Button()
        Me.SupplierButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.InventoryBox = New System.Windows.Forms.TextBox()
        Me.SerialNumberBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DisposedTick = New System.Windows.Forms.CheckBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.PurchaseCostBox = New System.Windows.Forms.TextBox()
        Me.ConnectionStringBox = New System.Windows.Forms.TextBox()
        Me.PurchaseDateBox = New System.Windows.Forms.TextBox()
        Me.ConnectionStringLabel = New System.Windows.Forms.Label()
        Me.SupplierCombo = New System.Windows.Forms.ComboBox()
        Me.TblSupplierBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MakeLabel = New System.Windows.Forms.Label()
        Me.LocationCombo = New System.Windows.Forms.ComboBox()
        Me.TblLocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModelLabel = New System.Windows.Forms.Label()
        Me.IPAddressBox = New System.Windows.Forms.TextBox()
        Me.ModelBox = New System.Windows.Forms.TextBox()
        Me.LocationLabel = New System.Windows.Forms.Label()
        Me.MakeBox = New System.Windows.Forms.TextBox()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.PurchaseDateLabel = New System.Windows.Forms.Label()
        Me.PurchaseCostLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.PrinterInfoList = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.CreatePrinterButton = New System.Windows.Forms.Button()
        Me.ShowDisposedButton = New System.Windows.Forms.CheckBox()
        Me.SavePrinterButton = New System.Windows.Forms.Button()
        Me.DeletePrinterButton = New System.Windows.Forms.Button()
        Me.TblSupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_PrinterTableAdapter = New ZuulEditor.ZuulDataSetTableAdapters.Tbl_PrinterTableAdapter()
        Me.Tbl_SupplierTableAdapter = New ZuulEditor.ZuulDataSetTableAdapters.Tbl_SupplierTableAdapter()
        Me.Tbl_LocationTableAdapter = New ZuulEditor.ZuulDataSetTableAdapters.Tbl_LocationTableAdapter()
        Me.Lnk_PrinterInfoTableAdapter1 = New ZuulEditor.ZuulDataSetTableAdapters.Lnk_PrinterInfoTableAdapter()
        Me.Tbl_InfoTableAdapter1 = New ZuulEditor.ZuulDataSetTableAdapters.Tbl_InfoTableAdapter()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.TblPrinterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZuulDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSupplierBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblLocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PrinterInfoList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.TblSupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.0356!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.9644!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PrinterListBox, 0, 1)
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(927, 531)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Printers"
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
        'PrinterListBox
        '
        Me.PrinterListBox.DataSource = Me.TblPrinterBindingSource
        Me.PrinterListBox.DisplayMember = "Name"
        Me.PrinterListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrinterListBox.FormattingEnabled = True
        Me.PrinterListBox.Location = New System.Drawing.Point(3, 38)
        Me.PrinterListBox.Name = "PrinterListBox"
        Me.PrinterListBox.Size = New System.Drawing.Size(189, 455)
        Me.PrinterListBox.Sorted = True
        Me.PrinterListBox.TabIndex = 2
        '
        'TblPrinterBindingSource
        '
        Me.TblPrinterBindingSource.DataMember = "Tbl_Printer"
        Me.TblPrinterBindingSource.DataSource = Me.ZuulDataSet
        '
        'ZuulDataSet
        '
        Me.ZuulDataSet.DataSetName = "ZuulDataSet"
        Me.ZuulDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SplitContainer1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(198, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(726, 455)
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.RadioButton1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.UserSelectable)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SearchModelRadio)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SearchInvRadio)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SearchSerialRadio)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SearchMakeRadio)
        Me.SplitContainer1.Panel1.Controls.Add(Me.IPAddressButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SupplierButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.InventoryBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SerialNumberBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DisposedTick)
        Me.SplitContainer1.Panel1.Controls.Add(Me.NameLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PurchaseCostBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ConnectionStringBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PurchaseDateBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ConnectionStringLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SupplierCombo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MakeLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LocationCombo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ModelLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.IPAddressBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ModelBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LocationLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MakeBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.NameBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PurchaseDateLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PurchaseCostLabel)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(726, 455)
        Me.SplitContainer1.SplitterDistance = 195
        Me.SplitContainer1.TabIndex = 18
        '
        'UserSelectable
        '
        Me.UserSelectable.AutoSize = True
        Me.UserSelectable.Location = New System.Drawing.Point(610, 34)
        Me.UserSelectable.Name = "UserSelectable"
        Me.UserSelectable.Size = New System.Drawing.Size(101, 17)
        Me.UserSelectable.TabIndex = 30
        Me.UserSelectable.Text = "User Selectable"
        Me.UserSelectable.UseVisualStyleBackColor = True
        '
        'SearchModelRadio
        '
        Me.SearchModelRadio.AutoSize = True
        Me.SearchModelRadio.Location = New System.Drawing.Point(219, 88)
        Me.SearchModelRadio.Name = "SearchModelRadio"
        Me.SearchModelRadio.Size = New System.Drawing.Size(59, 17)
        Me.SearchModelRadio.TabIndex = 29
        Me.SearchModelRadio.TabStop = True
        Me.SearchModelRadio.Text = "Search"
        Me.SearchModelRadio.UseVisualStyleBackColor = True
        '
        'SearchInvRadio
        '
        Me.SearchInvRadio.AutoSize = True
        Me.SearchInvRadio.Location = New System.Drawing.Point(528, 38)
        Me.SearchInvRadio.Name = "SearchInvRadio"
        Me.SearchInvRadio.Size = New System.Drawing.Size(59, 17)
        Me.SearchInvRadio.TabIndex = 28
        Me.SearchInvRadio.TabStop = True
        Me.SearchInvRadio.Text = "Search"
        Me.SearchInvRadio.UseVisualStyleBackColor = True
        '
        'SearchSerialRadio
        '
        Me.SearchSerialRadio.AutoSize = True
        Me.SearchSerialRadio.Location = New System.Drawing.Point(528, 12)
        Me.SearchSerialRadio.Name = "SearchSerialRadio"
        Me.SearchSerialRadio.Size = New System.Drawing.Size(59, 17)
        Me.SearchSerialRadio.TabIndex = 27
        Me.SearchSerialRadio.TabStop = True
        Me.SearchSerialRadio.Text = "Search"
        Me.SearchSerialRadio.UseVisualStyleBackColor = True
        '
        'SearchMakeRadio
        '
        Me.SearchMakeRadio.AutoSize = True
        Me.SearchMakeRadio.Location = New System.Drawing.Point(219, 64)
        Me.SearchMakeRadio.Name = "SearchMakeRadio"
        Me.SearchMakeRadio.Size = New System.Drawing.Size(59, 17)
        Me.SearchMakeRadio.TabIndex = 26
        Me.SearchMakeRadio.TabStop = True
        Me.SearchMakeRadio.Text = "Search"
        Me.SearchMakeRadio.UseVisualStyleBackColor = True
        '
        'IPAddressButton
        '
        Me.IPAddressButton.Location = New System.Drawing.Point(-1, 111)
        Me.IPAddressButton.Name = "IPAddressButton"
        Me.IPAddressButton.Size = New System.Drawing.Size(82, 23)
        Me.IPAddressButton.TabIndex = 25
        Me.IPAddressButton.Text = "IP Address"
        Me.IPAddressButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IPAddressButton.UseVisualStyleBackColor = True
        '
        'SupplierButton
        '
        Me.SupplierButton.Location = New System.Drawing.Point(509, 165)
        Me.SupplierButton.Name = "SupplierButton"
        Me.SupplierButton.Size = New System.Drawing.Size(81, 23)
        Me.SupplierButton.TabIndex = 24
        Me.SupplierButton.Text = "Supplier"
        Me.SupplierButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SupplierButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ZuulEditor.My.Resources.Resources.Printer
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
        Me.DisposedTick.Location = New System.Drawing.Point(610, 13)
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
        'ConnectionStringBox
        '
        Me.ConnectionStringBox.Location = New System.Drawing.Point(113, 35)
        Me.ConnectionStringBox.Name = "ConnectionStringBox"
        Me.ConnectionStringBox.Size = New System.Drawing.Size(209, 20)
        Me.ConnectionStringBox.TabIndex = 0
        '
        'PurchaseDateBox
        '
        Me.PurchaseDateBox.Location = New System.Drawing.Point(596, 117)
        Me.PurchaseDateBox.Name = "PurchaseDateBox"
        Me.PurchaseDateBox.Size = New System.Drawing.Size(100, 20)
        Me.PurchaseDateBox.TabIndex = 16
        '
        'ConnectionStringLabel
        '
        Me.ConnectionStringLabel.AutoSize = True
        Me.ConnectionStringLabel.Location = New System.Drawing.Point(3, 38)
        Me.ConnectionStringLabel.Name = "ConnectionStringLabel"
        Me.ConnectionStringLabel.Size = New System.Drawing.Size(94, 13)
        Me.ConnectionStringLabel.TabIndex = 1
        Me.ConnectionStringLabel.Text = "Connecttion String"
        '
        'SupplierCombo
        '
        Me.SupplierCombo.DataSource = Me.TblSupplierBindingSource1
        Me.SupplierCombo.DisplayMember = "Name"
        Me.SupplierCombo.FormattingEnabled = True
        Me.SupplierCombo.Location = New System.Drawing.Point(596, 167)
        Me.SupplierCombo.Name = "SupplierCombo"
        Me.SupplierCombo.Size = New System.Drawing.Size(121, 21)
        Me.SupplierCombo.TabIndex = 15
        '
        'TblSupplierBindingSource1
        '
        Me.TblSupplierBindingSource1.DataMember = "Tbl_Supplier"
        Me.TblSupplierBindingSource1.DataSource = Me.ZuulDataSet
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
        'IPAddressBox
        '
        Me.IPAddressBox.Location = New System.Drawing.Point(113, 113)
        Me.IPAddressBox.Name = "IPAddressBox"
        Me.IPAddressBox.Size = New System.Drawing.Size(100, 20)
        Me.IPAddressBox.TabIndex = 13
        '
        'ModelBox
        '
        Me.ModelBox.Location = New System.Drawing.Point(113, 87)
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
        Me.MakeBox.Location = New System.Drawing.Point(113, 61)
        Me.MakeBox.Name = "MakeBox"
        Me.MakeBox.Size = New System.Drawing.Size(100, 20)
        Me.MakeBox.TabIndex = 11
        '
        'NameBox
        '
        Me.NameBox.Location = New System.Drawing.Point(113, 9)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(100, 20)
        Me.NameBox.TabIndex = 10
        '
        'PurchaseDateLabel
        '
        Me.PurchaseDateLabel.AutoSize = True
        Me.PurchaseDateLabel.Location = New System.Drawing.Point(512, 120)
        Me.PurchaseDateLabel.Name = "PurchaseDateLabel"
        Me.PurchaseDateLabel.Size = New System.Drawing.Size(78, 13)
        Me.PurchaseDateLabel.TabIndex = 7
        Me.PurchaseDateLabel.Text = "Purchase Date"
        '
        'PurchaseCostLabel
        '
        Me.PurchaseCostLabel.AutoSize = True
        Me.PurchaseCostLabel.Location = New System.Drawing.Point(512, 147)
        Me.PurchaseCostLabel.Name = "PurchaseCostLabel"
        Me.PurchaseCostLabel.Size = New System.Drawing.Size(76, 13)
        Me.PurchaseCostLabel.TabIndex = 8
        Me.PurchaseCostLabel.Text = "Purchase Cost"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.PrinterInfoList, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(724, 254)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'PrinterInfoList
        '
        Me.PrinterInfoList.AllowUserToAddRows = False
        Me.PrinterInfoList.AllowUserToDeleteRows = False
        Me.PrinterInfoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PrinterInfoList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrinterInfoList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.PrinterInfoList.Location = New System.Drawing.Point(3, 3)
        Me.PrinterInfoList.Name = "PrinterInfoList"
        Me.PrinterInfoList.Size = New System.Drawing.Size(587, 248)
        Me.PrinterInfoList.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(596, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(125, 248)
        Me.Panel2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.Location = New System.Drawing.Point(0, 225)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add Note"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel3, 2)
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 332.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.CreatePrinterButton, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.ShowDisposedButton, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.SavePrinterButton, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.DeletePrinterButton, 2, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 499)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(921, 29)
        Me.TableLayoutPanel3.TabIndex = 4
        '
        'CreatePrinterButton
        '
        Me.CreatePrinterButton.Location = New System.Drawing.Point(3, 3)
        Me.CreatePrinterButton.Name = "CreatePrinterButton"
        Me.CreatePrinterButton.Size = New System.Drawing.Size(107, 23)
        Me.CreatePrinterButton.TabIndex = 6
        Me.CreatePrinterButton.Text = "Create Printer"
        Me.CreatePrinterButton.UseVisualStyleBackColor = True
        '
        'ShowDisposedButton
        '
        Me.ShowDisposedButton.AutoSize = True
        Me.ShowDisposedButton.Location = New System.Drawing.Point(116, 3)
        Me.ShowDisposedButton.Name = "ShowDisposedButton"
        Me.ShowDisposedButton.Size = New System.Drawing.Size(100, 17)
        Me.ShowDisposedButton.TabIndex = 7
        Me.ShowDisposedButton.Text = "Show Disposed"
        Me.ShowDisposedButton.ThreeState = True
        Me.ShowDisposedButton.UseVisualStyleBackColor = True
        '
        'SavePrinterButton
        '
        Me.SavePrinterButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SavePrinterButton.Enabled = False
        Me.SavePrinterButton.Location = New System.Drawing.Point(792, 3)
        Me.SavePrinterButton.Name = "SavePrinterButton"
        Me.SavePrinterButton.Size = New System.Drawing.Size(126, 23)
        Me.SavePrinterButton.TabIndex = 8
        Me.SavePrinterButton.Text = "Save Printer Details"
        Me.SavePrinterButton.UseVisualStyleBackColor = True
        '
        'DeletePrinterButton
        '
        Me.DeletePrinterButton.Location = New System.Drawing.Point(448, 3)
        Me.DeletePrinterButton.Name = "DeletePrinterButton"
        Me.DeletePrinterButton.Size = New System.Drawing.Size(91, 23)
        Me.DeletePrinterButton.TabIndex = 9
        Me.DeletePrinterButton.Text = "Delete Printer"
        Me.DeletePrinterButton.UseVisualStyleBackColor = True
        '
        'TblSupplierBindingSource
        '
        Me.TblSupplierBindingSource.DataSource = Me.ZuulDataSet
        Me.TblSupplierBindingSource.Position = 0
        '
        'Tbl_PrinterTableAdapter
        '
        Me.Tbl_PrinterTableAdapter.ClearBeforeFill = True
        '
        'Tbl_SupplierTableAdapter
        '
        Me.Tbl_SupplierTableAdapter.ClearBeforeFill = True
        '
        'Tbl_LocationTableAdapter
        '
        Me.Tbl_LocationTableAdapter.ClearBeforeFill = True
        '
        'Lnk_PrinterInfoTableAdapter1
        '
        Me.Lnk_PrinterInfoTableAdapter1.ClearBeforeFill = True
        '
        'Tbl_InfoTableAdapter1
        '
        Me.Tbl_InfoTableAdapter1.ClearBeforeFill = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(219, 10)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(59, 17)
        Me.RadioButton1.TabIndex = 31
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Search"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'PrinterDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 531)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "PrinterDetail"
        Me.Text = "PrinterDetail"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.TblPrinterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZuulDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSupplierBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblLocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.PrinterInfoList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.TblSupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PrinterListBox As ListBox
    Friend WithEvents ZuulDataSet As ZuulDataSet
    Friend WithEvents TblPrinterBindingSource As BindingSource
    Friend WithEvents Tbl_PrinterTableAdapter As ZuulDataSetTableAdapters.Tbl_PrinterTableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LocationCombo As ComboBox
    Friend WithEvents IPAddressBox As TextBox
    Friend WithEvents ModelBox As TextBox
    Friend WithEvents MakeBox As TextBox
    Friend WithEvents NameBox As TextBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents PurchaseCostLabel As Label
    Friend WithEvents PurchaseDateLabel As Label
    Friend WithEvents LocationLabel As Label
    Friend WithEvents ModelLabel As Label
    Friend WithEvents MakeLabel As Label
    Friend WithEvents ConnectionStringLabel As Label
    Friend WithEvents ConnectionStringBox As TextBox
    Friend WithEvents SupplierCombo As ComboBox
    Friend WithEvents PurchaseCostBox As TextBox
    Friend WithEvents PurchaseDateBox As TextBox
    Friend WithEvents TblSupplierBindingSource As BindingSource
    Friend WithEvents Tbl_SupplierTableAdapter As ZuulDataSetTableAdapters.Tbl_SupplierTableAdapter
    Friend WithEvents TblLocationBindingSource As BindingSource
    Friend WithEvents Tbl_LocationTableAdapter As ZuulDataSetTableAdapters.Tbl_LocationTableAdapter
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TblSupplierBindingSource1 As BindingSource
    Friend WithEvents Lnk_PrinterInfoTableAdapter1 As ZuulDataSetTableAdapters.Lnk_PrinterInfoTableAdapter
    Friend WithEvents Tbl_InfoTableAdapter1 As ZuulDataSetTableAdapters.Tbl_InfoTableAdapter
    Friend WithEvents PrinterInfoList As DataGridView
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents InventoryBox As TextBox
    Friend WithEvents SerialNumberBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DisposedTick As CheckBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents CreatePrinterButton As Button
    Friend WithEvents ShowDisposedButton As CheckBox
    Friend WithEvents SavePrinterButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DeletePrinterButton As Button
    Friend WithEvents IPAddressButton As Button
    Friend WithEvents SupplierButton As Button
    Friend WithEvents SearchModelRadio As RadioButton
    Friend WithEvents SearchInvRadio As RadioButton
    Friend WithEvents SearchSerialRadio As RadioButton
    Friend WithEvents SearchMakeRadio As RadioButton
    Friend WithEvents UserSelectable As CheckBox
    Friend WithEvents RadioButton1 As RadioButton
End Class
