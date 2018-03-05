<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.PrinterAssignButton = New System.Windows.Forms.Button()
        Me.PrinterDetailsButton = New System.Windows.Forms.Button()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.PrivAssignButton = New System.Windows.Forms.Button()
        Me.ComputerDetailButton = New System.Windows.Forms.Button()
        Me.ProjectorDetailButton = New System.Windows.Forms.Button()
        Me.OtherHardwareButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImportComputersButton = New System.Windows.Forms.Button()
        Me.ImportUsersButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PrinterAssignButton
        '
        Me.PrinterAssignButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.PrinterAssignButton.Location = New System.Drawing.Point(0, 46)
        Me.PrinterAssignButton.Name = "PrinterAssignButton"
        Me.PrinterAssignButton.Size = New System.Drawing.Size(369, 23)
        Me.PrinterAssignButton.TabIndex = 1
        Me.PrinterAssignButton.Text = "Assign Printers"
        Me.PrinterAssignButton.UseVisualStyleBackColor = True
        '
        'PrinterDetailsButton
        '
        Me.PrinterDetailsButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.PrinterDetailsButton.Location = New System.Drawing.Point(0, 69)
        Me.PrinterDetailsButton.Name = "PrinterDetailsButton"
        Me.PrinterDetailsButton.Size = New System.Drawing.Size(369, 23)
        Me.PrinterDetailsButton.TabIndex = 2
        Me.PrinterDetailsButton.Text = "Printer Details"
        Me.PrinterDetailsButton.UseVisualStyleBackColor = True
        '
        'SearchButton
        '
        Me.SearchButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.SearchButton.Location = New System.Drawing.Point(0, 0)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(369, 23)
        Me.SearchButton.TabIndex = 0
        Me.SearchButton.Text = "Find"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'PrivAssignButton
        '
        Me.PrivAssignButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.PrivAssignButton.Location = New System.Drawing.Point(0, 23)
        Me.PrivAssignButton.Name = "PrivAssignButton"
        Me.PrivAssignButton.Size = New System.Drawing.Size(369, 23)
        Me.PrivAssignButton.TabIndex = 3
        Me.PrivAssignButton.Text = "Assign Priv User"
        Me.PrivAssignButton.UseVisualStyleBackColor = True
        '
        'ComputerDetailButton
        '
        Me.ComputerDetailButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.ComputerDetailButton.Location = New System.Drawing.Point(0, 92)
        Me.ComputerDetailButton.Name = "ComputerDetailButton"
        Me.ComputerDetailButton.Size = New System.Drawing.Size(369, 23)
        Me.ComputerDetailButton.TabIndex = 4
        Me.ComputerDetailButton.Text = "Computer Details"
        Me.ComputerDetailButton.UseVisualStyleBackColor = True
        '
        'ProjectorDetailButton
        '
        Me.ProjectorDetailButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProjectorDetailButton.Location = New System.Drawing.Point(0, 115)
        Me.ProjectorDetailButton.Name = "ProjectorDetailButton"
        Me.ProjectorDetailButton.Size = New System.Drawing.Size(369, 23)
        Me.ProjectorDetailButton.TabIndex = 5
        Me.ProjectorDetailButton.Text = "Projector Details"
        Me.ProjectorDetailButton.UseVisualStyleBackColor = True
        '
        'OtherHardwareButton
        '
        Me.OtherHardwareButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.OtherHardwareButton.Location = New System.Drawing.Point(0, 138)
        Me.OtherHardwareButton.Name = "OtherHardwareButton"
        Me.OtherHardwareButton.Size = New System.Drawing.Size(369, 23)
        Me.OtherHardwareButton.TabIndex = 6
        Me.OtherHardwareButton.Text = "Other Hardware"
        Me.OtherHardwareButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.Location = New System.Drawing.Point(0, 161)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(369, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Upload Files"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 8
        '
        'ImportComputersButton
        '
        Me.ImportComputersButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.ImportComputersButton.Location = New System.Drawing.Point(0, 197)
        Me.ImportComputersButton.Name = "ImportComputersButton"
        Me.ImportComputersButton.Size = New System.Drawing.Size(369, 23)
        Me.ImportComputersButton.TabIndex = 9
        Me.ImportComputersButton.Text = "Import Computers from AD"
        Me.ImportComputersButton.UseVisualStyleBackColor = True
        '
        'ImportUsersButton
        '
        Me.ImportUsersButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.ImportUsersButton.Location = New System.Drawing.Point(0, 220)
        Me.ImportUsersButton.Name = "ImportUsersButton"
        Me.ImportUsersButton.Size = New System.Drawing.Size(369, 23)
        Me.ImportUsersButton.TabIndex = 10
        Me.ImportUsersButton.Text = "Import Users from AD"
        Me.ImportUsersButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 294)
        Me.Controls.Add(Me.ImportUsersButton)
        Me.Controls.Add(Me.ImportComputersButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.OtherHardwareButton)
        Me.Controls.Add(Me.ProjectorDetailButton)
        Me.Controls.Add(Me.ComputerDetailButton)
        Me.Controls.Add(Me.PrinterDetailsButton)
        Me.Controls.Add(Me.PrinterAssignButton)
        Me.Controls.Add(Me.PrivAssignButton)
        Me.Controls.Add(Me.SearchButton)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Network Services Inventory Management"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrinterAssignButton As Button
    Friend WithEvents PrinterDetailsButton As Button
    Friend WithEvents SearchButton As Button
    Friend WithEvents PrivAssignButton As Button
    Friend WithEvents ComputerDetailButton As Button
    Friend WithEvents ProjectorDetailButton As Button
    Friend WithEvents OtherHardwareButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ImportComputersButton As Button
    Friend WithEvents ImportUsersButton As Button
End Class
