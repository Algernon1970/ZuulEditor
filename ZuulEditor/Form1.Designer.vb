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
        Me.SuspendLayout()
        '
        'PrinterAssignButton
        '
        Me.PrinterAssignButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.PrinterAssignButton.Location = New System.Drawing.Point(0, 23)
        Me.PrinterAssignButton.Name = "PrinterAssignButton"
        Me.PrinterAssignButton.Size = New System.Drawing.Size(257, 23)
        Me.PrinterAssignButton.TabIndex = 1
        Me.PrinterAssignButton.Text = "Assign Printers"
        Me.PrinterAssignButton.UseVisualStyleBackColor = True
        '
        'PrinterDetailsButton
        '
        Me.PrinterDetailsButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.PrinterDetailsButton.Location = New System.Drawing.Point(0, 46)
        Me.PrinterDetailsButton.Name = "PrinterDetailsButton"
        Me.PrinterDetailsButton.Size = New System.Drawing.Size(257, 23)
        Me.PrinterDetailsButton.TabIndex = 2
        Me.PrinterDetailsButton.Text = "Printer Details"
        Me.PrinterDetailsButton.UseVisualStyleBackColor = True
        '
        'SearchButton
        '
        Me.SearchButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.SearchButton.Location = New System.Drawing.Point(0, 0)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(257, 23)
        Me.SearchButton.TabIndex = 0
        Me.SearchButton.Text = "Find"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 405)
        Me.Controls.Add(Me.PrinterDetailsButton)
        Me.Controls.Add(Me.PrinterAssignButton)
        Me.Controls.Add(Me.SearchButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PrinterAssignButton As Button
    Friend WithEvents PrinterDetailsButton As Button
    Friend WithEvents SearchButton As Button
End Class
