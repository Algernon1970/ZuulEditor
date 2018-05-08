<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AssignPrintersForm
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
        Me.PrinterListBox = New System.Windows.Forms.ListBox()
        Me.TblPrinterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ZuulDataSet = New ZuulEditor.ZuulDataSet()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ComputerListBox = New System.Windows.Forms.ListBox()
        Me.TblComputerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OperationBox = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.AssignButton = New System.Windows.Forms.Button()
        Me.DefaultButton = New System.Windows.Forms.Button()
        Me.UnAssignButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tbl_PrinterTableAdapter = New ZuulEditor.ZuulDataSetTableAdapters.Tbl_PrinterTableAdapter()
        Me.Tbl_ComputerTableAdapter = New ZuulEditor.ZuulDataSetTableAdapters.Tbl_ComputerTableAdapter()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.EditPrinterButton = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ComputerListFilterBox = New System.Windows.Forms.TextBox()
        Me.PrinterListFilterBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.TblPrinterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZuulDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.TblComputerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrinterListBox
        '
        Me.PrinterListBox.DataSource = Me.TblPrinterBindingSource
        Me.PrinterListBox.DisplayMember = "Name"
        Me.PrinterListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrinterListBox.FormattingEnabled = True
        Me.PrinterListBox.Location = New System.Drawing.Point(251, 38)
        Me.PrinterListBox.Name = "PrinterListBox"
        Me.PrinterListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.PrinterListBox.Size = New System.Drawing.Size(242, 457)
        Me.PrinterListBox.Sorted = True
        Me.PrinterListBox.TabIndex = 0
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.89667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.89667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.20666!))
        Me.TableLayoutPanel1.Controls.Add(Me.ComputerListBox, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.OperationBox, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.PrinterListBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(958, 567)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'ComputerListBox
        '
        Me.ComputerListBox.DataSource = Me.TblComputerBindingSource
        Me.ComputerListBox.DisplayMember = "Name"
        Me.ComputerListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComputerListBox.FormattingEnabled = True
        Me.ComputerListBox.Location = New System.Drawing.Point(3, 38)
        Me.ComputerListBox.Name = "ComputerListBox"
        Me.ComputerListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ComputerListBox.Size = New System.Drawing.Size(242, 457)
        Me.ComputerListBox.Sorted = True
        Me.ComputerListBox.TabIndex = 2
        '
        'TblComputerBindingSource
        '
        Me.TblComputerBindingSource.DataMember = "Tbl_Computer"
        Me.TblComputerBindingSource.DataSource = Me.ZuulDataSet
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(242, 35)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Computer List"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OperationBox
        '
        Me.OperationBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OperationBox.Location = New System.Drawing.Point(499, 38)
        Me.OperationBox.Name = "OperationBox"
        Me.OperationBox.Size = New System.Drawing.Size(456, 457)
        Me.OperationBox.TabIndex = 4
        Me.OperationBox.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(499, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(456, 35)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Operation"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.AssignButton, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.DefaultButton, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.UnAssignButton, 2, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(499, 501)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(456, 63)
        Me.TableLayoutPanel2.TabIndex = 6
        '
        'AssignButton
        '
        Me.AssignButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AssignButton.Location = New System.Drawing.Point(3, 35)
        Me.AssignButton.Name = "AssignButton"
        Me.AssignButton.Size = New System.Drawing.Size(146, 25)
        Me.AssignButton.TabIndex = 0
        Me.AssignButton.Text = "Assign"
        Me.AssignButton.UseVisualStyleBackColor = True
        '
        'DefaultButton
        '
        Me.DefaultButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DefaultButton.Location = New System.Drawing.Point(155, 35)
        Me.DefaultButton.Name = "DefaultButton"
        Me.DefaultButton.Size = New System.Drawing.Size(146, 25)
        Me.DefaultButton.TabIndex = 1
        Me.DefaultButton.Text = "Default"
        Me.DefaultButton.UseVisualStyleBackColor = True
        '
        'UnAssignButton
        '
        Me.UnAssignButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UnAssignButton.Location = New System.Drawing.Point(307, 35)
        Me.UnAssignButton.Name = "UnAssignButton"
        Me.UnAssignButton.Size = New System.Drawing.Size(146, 25)
        Me.UnAssignButton.TabIndex = 2
        Me.UnAssignButton.Text = "UnAssign"
        Me.UnAssignButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(251, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 35)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Available Printers"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_PrinterTableAdapter
        '
        Me.Tbl_PrinterTableAdapter.ClearBeforeFill = True
        '
        'Tbl_ComputerTableAdapter
        '
        Me.Tbl_ComputerTableAdapter.ClearBeforeFill = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Button1, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 501)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(242, 63)
        Me.TableLayoutPanel3.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Location = New System.Drawing.Point(3, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(236, 26)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Computer Details"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.EditPrinterButton, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.FlowLayoutPanel2, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(251, 501)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(242, 63)
        Me.TableLayoutPanel4.TabIndex = 11
        '
        'EditPrinterButton
        '
        Me.EditPrinterButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EditPrinterButton.Location = New System.Drawing.Point(3, 34)
        Me.EditPrinterButton.Name = "EditPrinterButton"
        Me.EditPrinterButton.Size = New System.Drawing.Size(236, 26)
        Me.EditPrinterButton.TabIndex = 10
        Me.EditPrinterButton.Text = "Printer Details"
        Me.EditPrinterButton.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel1.Controls.Add(Me.ComputerListFilterBox)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(236, 25)
        Me.FlowLayoutPanel1.TabIndex = 10
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel2.Controls.Add(Me.PrinterListFilterBox)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(236, 25)
        Me.FlowLayoutPanel2.TabIndex = 11
        '
        'ComputerListFilterBox
        '
        Me.ComputerListFilterBox.Location = New System.Drawing.Point(38, 3)
        Me.ComputerListFilterBox.Name = "ComputerListFilterBox"
        Me.ComputerListFilterBox.Size = New System.Drawing.Size(100, 20)
        Me.ComputerListFilterBox.TabIndex = 1
        '
        'PrinterListFilterBox
        '
        Me.PrinterListFilterBox.Location = New System.Drawing.Point(38, 3)
        Me.PrinterListFilterBox.Name = "PrinterListFilterBox"
        Me.PrinterListFilterBox.Size = New System.Drawing.Size(100, 20)
        Me.PrinterListFilterBox.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 26)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Filter"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 26)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Filter"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AssignPrintersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 567)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "AssignPrintersForm"
        Me.Text = "AssignPrintersForm"
        CType(Me.TblPrinterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZuulDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.TblComputerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PrinterListBox As ListBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ZuulDataSet As ZuulDataSet
    Friend WithEvents TblPrinterBindingSource As BindingSource
    Friend WithEvents Tbl_PrinterTableAdapter As ZuulDataSetTableAdapters.Tbl_PrinterTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents ComputerListBox As ListBox
    Friend WithEvents TblComputerBindingSource As BindingSource
    Friend WithEvents Tbl_ComputerTableAdapter As ZuulDataSetTableAdapters.Tbl_ComputerTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents OperationBox As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents AssignButton As Button
    Friend WithEvents DefaultButton As Button
    Friend WithEvents UnAssignButton As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents ComputerListFilterBox As TextBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents EditPrinterButton As Button
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents PrinterListFilterBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
