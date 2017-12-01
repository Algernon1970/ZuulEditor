<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrinterDetail
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PrinterListBox = New System.Windows.Forms.ListBox()
        Me.TblPrinterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ZuulDataSet = New ZuulEditor.ZuulDataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SupplierCombo = New System.Windows.Forms.ComboBox()
        Me.TblSupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocationCombo = New System.Windows.Forms.ComboBox()
        Me.IPAddressBox = New System.Windows.Forms.TextBox()
        Me.ModelBox = New System.Windows.Forms.TextBox()
        Me.MakeBox = New System.Windows.Forms.TextBox()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.PurchaseCostLabel = New System.Windows.Forms.Label()
        Me.PurchaseDateLabel = New System.Windows.Forms.Label()
        Me.SupplierLabel = New System.Windows.Forms.Label()
        Me.LocationLabel = New System.Windows.Forms.Label()
        Me.IPAddressLabel = New System.Windows.Forms.Label()
        Me.ModelLabel = New System.Windows.Forms.Label()
        Me.MakeLabel = New System.Windows.Forms.Label()
        Me.ConnectionStringLabel = New System.Windows.Forms.Label()
        Me.ConnectionStringBox = New System.Windows.Forms.TextBox()
        Me.Tbl_PrinterTableAdapter = New ZuulEditor.ZuulDataSetTableAdapters.Tbl_PrinterTableAdapter()
        Me.Tbl_SupplierTableAdapter = New ZuulEditor.ZuulDataSetTableAdapters.Tbl_SupplierTableAdapter()
        Me.TblLocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_LocationTableAdapter = New ZuulEditor.ZuulDataSetTableAdapters.Tbl_LocationTableAdapter()
        Me.CreatePrinterButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.TblPrinterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZuulDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TblSupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblLocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Controls.Add(Me.CreatePrinterButton, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
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
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.SupplierCombo)
        Me.Panel1.Controls.Add(Me.LocationCombo)
        Me.Panel1.Controls.Add(Me.IPAddressBox)
        Me.Panel1.Controls.Add(Me.ModelBox)
        Me.Panel1.Controls.Add(Me.MakeBox)
        Me.Panel1.Controls.Add(Me.NameBox)
        Me.Panel1.Controls.Add(Me.NameLabel)
        Me.Panel1.Controls.Add(Me.PurchaseCostLabel)
        Me.Panel1.Controls.Add(Me.PurchaseDateLabel)
        Me.Panel1.Controls.Add(Me.SupplierLabel)
        Me.Panel1.Controls.Add(Me.LocationLabel)
        Me.Panel1.Controls.Add(Me.IPAddressLabel)
        Me.Panel1.Controls.Add(Me.ModelLabel)
        Me.Panel1.Controls.Add(Me.MakeLabel)
        Me.Panel1.Controls.Add(Me.ConnectionStringLabel)
        Me.Panel1.Controls.Add(Me.ConnectionStringBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(198, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(726, 455)
        Me.Panel1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(600, 394)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 17
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(386, 394)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 16
        '
        'SupplierCombo
        '
        Me.SupplierCombo.DataSource = Me.TblSupplierBindingSource
        Me.SupplierCombo.FormattingEnabled = True
        Me.SupplierCombo.Location = New System.Drawing.Point(353, 156)
        Me.SupplierCombo.Name = "SupplierCombo"
        Me.SupplierCombo.Size = New System.Drawing.Size(121, 21)
        Me.SupplierCombo.TabIndex = 15
        '
        'LocationCombo
        '
        Me.LocationCombo.DataSource = Me.TblLocationBindingSource
        Me.LocationCombo.DisplayMember = "LocationName"
        Me.LocationCombo.FormattingEnabled = True
        Me.LocationCombo.Location = New System.Drawing.Point(58, 156)
        Me.LocationCombo.Name = "LocationCombo"
        Me.LocationCombo.Size = New System.Drawing.Size(155, 21)
        Me.LocationCombo.TabIndex = 14
        '
        'IPAddressBox
        '
        Me.IPAddressBox.Location = New System.Drawing.Point(113, 107)
        Me.IPAddressBox.Name = "IPAddressBox"
        Me.IPAddressBox.Size = New System.Drawing.Size(100, 20)
        Me.IPAddressBox.TabIndex = 13
        '
        'ModelBox
        '
        Me.ModelBox.Location = New System.Drawing.Point(113, 81)
        Me.ModelBox.Name = "ModelBox"
        Me.ModelBox.Size = New System.Drawing.Size(100, 20)
        Me.ModelBox.TabIndex = 12
        '
        'MakeBox
        '
        Me.MakeBox.Location = New System.Drawing.Point(113, 55)
        Me.MakeBox.Name = "MakeBox"
        Me.MakeBox.Size = New System.Drawing.Size(100, 20)
        Me.MakeBox.TabIndex = 11
        '
        'NameBox
        '
        Me.NameBox.Location = New System.Drawing.Point(113, 3)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(100, 20)
        Me.NameBox.TabIndex = 10
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(3, 6)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(35, 13)
        Me.NameLabel.TabIndex = 9
        Me.NameLabel.Text = "Name"
        '
        'PurchaseCostLabel
        '
        Me.PurchaseCostLabel.AutoSize = True
        Me.PurchaseCostLabel.Location = New System.Drawing.Point(518, 397)
        Me.PurchaseCostLabel.Name = "PurchaseCostLabel"
        Me.PurchaseCostLabel.Size = New System.Drawing.Size(76, 13)
        Me.PurchaseCostLabel.TabIndex = 8
        Me.PurchaseCostLabel.Text = "Purchase Cost"
        '
        'PurchaseDateLabel
        '
        Me.PurchaseDateLabel.AutoSize = True
        Me.PurchaseDateLabel.Location = New System.Drawing.Point(302, 397)
        Me.PurchaseDateLabel.Name = "PurchaseDateLabel"
        Me.PurchaseDateLabel.Size = New System.Drawing.Size(78, 13)
        Me.PurchaseDateLabel.TabIndex = 7
        Me.PurchaseDateLabel.Text = "Purchase Date"
        '
        'SupplierLabel
        '
        Me.SupplierLabel.AutoSize = True
        Me.SupplierLabel.Location = New System.Drawing.Point(302, 159)
        Me.SupplierLabel.Name = "SupplierLabel"
        Me.SupplierLabel.Size = New System.Drawing.Size(45, 13)
        Me.SupplierLabel.TabIndex = 6
        Me.SupplierLabel.Text = "Supplier"
        '
        'LocationLabel
        '
        Me.LocationLabel.AutoSize = True
        Me.LocationLabel.Location = New System.Drawing.Point(4, 159)
        Me.LocationLabel.Name = "LocationLabel"
        Me.LocationLabel.Size = New System.Drawing.Size(48, 13)
        Me.LocationLabel.TabIndex = 5
        Me.LocationLabel.Text = "Location"
        '
        'IPAddressLabel
        '
        Me.IPAddressLabel.AutoSize = True
        Me.IPAddressLabel.Location = New System.Drawing.Point(4, 110)
        Me.IPAddressLabel.Name = "IPAddressLabel"
        Me.IPAddressLabel.Size = New System.Drawing.Size(55, 13)
        Me.IPAddressLabel.TabIndex = 4
        Me.IPAddressLabel.Text = "IPAddress"
        '
        'ModelLabel
        '
        Me.ModelLabel.AutoSize = True
        Me.ModelLabel.Location = New System.Drawing.Point(4, 84)
        Me.ModelLabel.Name = "ModelLabel"
        Me.ModelLabel.Size = New System.Drawing.Size(36, 13)
        Me.ModelLabel.TabIndex = 3
        Me.ModelLabel.Text = "Model"
        '
        'MakeLabel
        '
        Me.MakeLabel.AutoSize = True
        Me.MakeLabel.Location = New System.Drawing.Point(4, 58)
        Me.MakeLabel.Name = "MakeLabel"
        Me.MakeLabel.Size = New System.Drawing.Size(34, 13)
        Me.MakeLabel.TabIndex = 2
        Me.MakeLabel.Text = "Make"
        '
        'ConnectionStringLabel
        '
        Me.ConnectionStringLabel.AutoSize = True
        Me.ConnectionStringLabel.Location = New System.Drawing.Point(3, 32)
        Me.ConnectionStringLabel.Name = "ConnectionStringLabel"
        Me.ConnectionStringLabel.Size = New System.Drawing.Size(94, 13)
        Me.ConnectionStringLabel.TabIndex = 1
        Me.ConnectionStringLabel.Text = "Connecttion String"
        '
        'ConnectionStringBox
        '
        Me.ConnectionStringBox.Location = New System.Drawing.Point(113, 29)
        Me.ConnectionStringBox.Name = "ConnectionStringBox"
        Me.ConnectionStringBox.Size = New System.Drawing.Size(234, 20)
        Me.ConnectionStringBox.TabIndex = 0
        '
        'Tbl_PrinterTableAdapter
        '
        Me.Tbl_PrinterTableAdapter.ClearBeforeFill = True
        '
        'Tbl_SupplierTableAdapter
        '
        Me.Tbl_SupplierTableAdapter.ClearBeforeFill = True
        '
        'TblLocationBindingSource
        '
        Me.TblLocationBindingSource.DataMember = "Tbl_Location"
        Me.TblLocationBindingSource.DataSource = Me.ZuulDataSet
        '
        'Tbl_LocationTableAdapter
        '
        Me.Tbl_LocationTableAdapter.ClearBeforeFill = True
        '
        'CreatePrinterButton
        '
        Me.CreatePrinterButton.Location = New System.Drawing.Point(3, 499)
        Me.CreatePrinterButton.Name = "CreatePrinterButton"
        Me.CreatePrinterButton.Size = New System.Drawing.Size(99, 23)
        Me.CreatePrinterButton.TabIndex = 4
        Me.CreatePrinterButton.Text = "Add New Printer"
        Me.CreatePrinterButton.UseVisualStyleBackColor = True
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
        Me.Panel1.PerformLayout()
        CType(Me.TblSupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblLocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents SupplierLabel As Label
    Friend WithEvents LocationLabel As Label
    Friend WithEvents IPAddressLabel As Label
    Friend WithEvents ModelLabel As Label
    Friend WithEvents MakeLabel As Label
    Friend WithEvents ConnectionStringLabel As Label
    Friend WithEvents ConnectionStringBox As TextBox
    Friend WithEvents SupplierCombo As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TblSupplierBindingSource As BindingSource
    Friend WithEvents Tbl_SupplierTableAdapter As ZuulDataSetTableAdapters.Tbl_SupplierTableAdapter
    Friend WithEvents TblLocationBindingSource As BindingSource
    Friend WithEvents Tbl_LocationTableAdapter As ZuulDataSetTableAdapters.Tbl_LocationTableAdapter
    Friend WithEvents CreatePrinterButton As Button
End Class
