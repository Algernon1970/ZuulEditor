<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AssignPrivUser
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComputerListBox = New System.Windows.Forms.ListBox()
        Me.UserListBox = New System.Windows.Forms.ListBox()
        Me.OperationListBox = New System.Windows.Forms.ListBox()
        Me.ZuulDataSet = New ZuulEditor.ZuulDataSet()
        Me.TblPersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_PersonTableAdapter = New ZuulEditor.ZuulDataSetTableAdapters.Tbl_PersonTableAdapter()
        Me.TblComputerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_ComputerTableAdapter = New ZuulEditor.ZuulDataSetTableAdapters.Tbl_ComputerTableAdapter()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComputerFilterBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.UserFilterBox = New System.Windows.Forms.TextBox()
        Me.AssignPrivButton = New System.Windows.Forms.Button()
        Me.UnassignPrivButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ZuulDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblComputerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ComputerListBox, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.UserListBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.OperationListBox, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel3, 2, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(920, 485)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Computer"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(279, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(270, 35)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "User"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(555, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(362, 35)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Operation"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.ComputerListBox.Size = New System.Drawing.Size(270, 409)
        Me.ComputerListBox.Sorted = True
        Me.ComputerListBox.TabIndex = 3
        '
        'UserListBox
        '
        Me.UserListBox.DataSource = Me.TblPersonBindingSource
        Me.UserListBox.DisplayMember = "SamAccount"
        Me.UserListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UserListBox.FormattingEnabled = True
        Me.UserListBox.Location = New System.Drawing.Point(279, 38)
        Me.UserListBox.Name = "UserListBox"
        Me.UserListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.UserListBox.Size = New System.Drawing.Size(270, 409)
        Me.UserListBox.Sorted = True
        Me.UserListBox.TabIndex = 4
        '
        'OperationListBox
        '
        Me.OperationListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OperationListBox.FormattingEnabled = True
        Me.OperationListBox.Location = New System.Drawing.Point(555, 38)
        Me.OperationListBox.Name = "OperationListBox"
        Me.OperationListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.OperationListBox.Size = New System.Drawing.Size(362, 409)
        Me.OperationListBox.TabIndex = 5
        '
        'ZuulDataSet
        '
        Me.ZuulDataSet.DataSetName = "ZuulDataSet"
        Me.ZuulDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblPersonBindingSource
        '
        Me.TblPersonBindingSource.DataMember = "Tbl_Person"
        Me.TblPersonBindingSource.DataSource = Me.ZuulDataSet
        '
        'Tbl_PersonTableAdapter
        '
        Me.Tbl_PersonTableAdapter.ClearBeforeFill = True
        '
        'TblComputerBindingSource
        '
        Me.TblComputerBindingSource.DataMember = "Tbl_Computer"
        Me.TblComputerBindingSource.DataSource = Me.ZuulDataSet
        '
        'Tbl_ComputerTableAdapter
        '
        Me.Tbl_ComputerTableAdapter.ClearBeforeFill = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel1.Controls.Add(Me.ComputerFilterBox)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 453)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(270, 29)
        Me.FlowLayoutPanel1.TabIndex = 6
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel2.Controls.Add(Me.UserFilterBox)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(279, 453)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(270, 29)
        Me.FlowLayoutPanel2.TabIndex = 7
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.AssignPrivButton)
        Me.FlowLayoutPanel3.Controls.Add(Me.UnassignPrivButton)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(555, 453)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(362, 29)
        Me.FlowLayoutPanel3.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Filter"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComputerFilterBox
        '
        Me.ComputerFilterBox.Location = New System.Drawing.Point(38, 3)
        Me.ComputerFilterBox.Name = "ComputerFilterBox"
        Me.ComputerFilterBox.Size = New System.Drawing.Size(114, 20)
        Me.ComputerFilterBox.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Filter"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UserFilterBox
        '
        Me.UserFilterBox.Location = New System.Drawing.Point(38, 3)
        Me.UserFilterBox.Name = "UserFilterBox"
        Me.UserFilterBox.Size = New System.Drawing.Size(126, 20)
        Me.UserFilterBox.TabIndex = 1
        '
        'AssignPrivButton
        '
        Me.AssignPrivButton.Location = New System.Drawing.Point(3, 3)
        Me.AssignPrivButton.Name = "AssignPrivButton"
        Me.AssignPrivButton.Size = New System.Drawing.Size(75, 23)
        Me.AssignPrivButton.TabIndex = 0
        Me.AssignPrivButton.Text = "Assign"
        Me.AssignPrivButton.UseVisualStyleBackColor = True
        '
        'UnassignPrivButton
        '
        Me.UnassignPrivButton.Location = New System.Drawing.Point(84, 3)
        Me.UnassignPrivButton.Name = "UnassignPrivButton"
        Me.UnassignPrivButton.Size = New System.Drawing.Size(75, 23)
        Me.UnassignPrivButton.TabIndex = 1
        Me.UnassignPrivButton.Text = "UnAssign"
        Me.UnassignPrivButton.UseVisualStyleBackColor = True
        '
        'AssignPrivUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 485)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "AssignPrivUser"
        Me.Text = "AssignPrivUser"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.ZuulDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblComputerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComputerListBox As ListBox
    Friend WithEvents UserListBox As ListBox
    Friend WithEvents OperationListBox As ListBox
    Friend WithEvents ZuulDataSet As ZuulDataSet
    Friend WithEvents TblPersonBindingSource As BindingSource
    Friend WithEvents Tbl_PersonTableAdapter As ZuulDataSetTableAdapters.Tbl_PersonTableAdapter
    Friend WithEvents TblComputerBindingSource As BindingSource
    Friend WithEvents Tbl_ComputerTableAdapter As ZuulDataSetTableAdapters.Tbl_ComputerTableAdapter
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents ComputerFilterBox As TextBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents UserFilterBox As TextBox
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents AssignPrivButton As Button
    Friend WithEvents UnassignPrivButton As Button
End Class
