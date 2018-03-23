<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportFromCSV
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
        Me.ImportButton = New System.Windows.Forms.Button()
        Me.Label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImportProgress = New System.Windows.Forms.ProgressBar()
        Me.Outbox = New System.Windows.Forms.RichTextBox()
        Me.CSVBrowser = New System.Windows.Forms.OpenFileDialog()
        Me.Lnk_ComputerPersonTableAdapter1 = New ZuulEditor.ZuulDataSetTableAdapters.Lnk_ComputerPersonTableAdapter()
        Me.Lnk_ComputerPrinterTableAdapter1 = New ZuulEditor.ZuulDataSetTableAdapters.Lnk_ComputerPrinterTableAdapter()
        Me.Tbl_PersonTableAdapter1 = New ZuulEditor.ZuulDataSetTableAdapters.Tbl_PersonTableAdapter()
        Me.Tbl_ComputerTableAdapter1 = New ZuulEditor.ZuulDataSetTableAdapters.Tbl_ComputerTableAdapter()
        Me.Tbl_PrinterTableAdapter1 = New ZuulEditor.ZuulDataSetTableAdapters.Tbl_PrinterTableAdapter()
        Me.Tbl_SupplierTableAdapter1 = New ZuulEditor.ZuulDataSetTableAdapters.Tbl_SupplierTableAdapter()
        Me.Tbl_LocationTableAdapter1 = New ZuulEditor.ZuulDataSetTableAdapters.Tbl_LocationTableAdapter()
        Me.SuspendLayout()
        '
        'ImportButton
        '
        Me.ImportButton.Location = New System.Drawing.Point(374, 140)
        Me.ImportButton.Name = "ImportButton"
        Me.ImportButton.Size = New System.Drawing.Size(98, 34)
        Me.ImportButton.TabIndex = 9
        Me.ImportButton.Text = "Import From CSV"
        Me.ImportButton.UseVisualStyleBackColor = True
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(9, 11)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(42, 13)
        Me.Label.TabIndex = 8
        Me.Label.Text = "Results"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Import Progress"
        '
        'ImportProgress
        '
        Me.ImportProgress.Location = New System.Drawing.Point(95, 180)
        Me.ImportProgress.Name = "ImportProgress"
        Me.ImportProgress.Size = New System.Drawing.Size(377, 13)
        Me.ImportProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ImportProgress.TabIndex = 5
        '
        'Outbox
        '
        Me.Outbox.Location = New System.Drawing.Point(12, 27)
        Me.Outbox.Name = "Outbox"
        Me.Outbox.Size = New System.Drawing.Size(332, 147)
        Me.Outbox.TabIndex = 10
        Me.Outbox.Text = ""
        '
        'CSVBrowser
        '
        Me.CSVBrowser.DefaultExt = "csv"
        Me.CSVBrowser.Filter = "Comma Separated Values|*.csv"
        Me.CSVBrowser.RestoreDirectory = True
        '
        'Lnk_ComputerPersonTableAdapter1
        '
        Me.Lnk_ComputerPersonTableAdapter1.ClearBeforeFill = True
        '
        'Lnk_ComputerPrinterTableAdapter1
        '
        Me.Lnk_ComputerPrinterTableAdapter1.ClearBeforeFill = True
        '
        'Tbl_PersonTableAdapter1
        '
        Me.Tbl_PersonTableAdapter1.ClearBeforeFill = True
        '
        'Tbl_ComputerTableAdapter1
        '
        Me.Tbl_ComputerTableAdapter1.ClearBeforeFill = True
        '
        'Tbl_PrinterTableAdapter1
        '
        Me.Tbl_PrinterTableAdapter1.ClearBeforeFill = True
        '
        'Tbl_SupplierTableAdapter1
        '
        Me.Tbl_SupplierTableAdapter1.ClearBeforeFill = True
        '
        'Tbl_LocationTableAdapter1
        '
        Me.Tbl_LocationTableAdapter1.ClearBeforeFill = True
        '
        'ImportFromCSV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 204)
        Me.Controls.Add(Me.Outbox)
        Me.Controls.Add(Me.ImportButton)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ImportProgress)
        Me.Name = "ImportFromCSV"
        Me.Text = "ImportFromCSV"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ImportButton As Button
    Friend WithEvents Label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ImportProgress As ProgressBar
    Friend WithEvents Outbox As RichTextBox
    Friend WithEvents CSVBrowser As OpenFileDialog
    Friend WithEvents Lnk_ComputerPersonTableAdapter1 As ZuulDataSetTableAdapters.Lnk_ComputerPersonTableAdapter
    Friend WithEvents Lnk_ComputerPrinterTableAdapter1 As ZuulDataSetTableAdapters.Lnk_ComputerPrinterTableAdapter
    Friend WithEvents Tbl_PersonTableAdapter1 As ZuulDataSetTableAdapters.Tbl_PersonTableAdapter
    Friend WithEvents Tbl_ComputerTableAdapter1 As ZuulDataSetTableAdapters.Tbl_ComputerTableAdapter
    Friend WithEvents Tbl_PrinterTableAdapter1 As ZuulDataSetTableAdapters.Tbl_PrinterTableAdapter
    Friend WithEvents Tbl_SupplierTableAdapter1 As ZuulDataSetTableAdapters.Tbl_SupplierTableAdapter
    Friend WithEvents Tbl_LocationTableAdapter1 As ZuulDataSetTableAdapters.Tbl_LocationTableAdapter
End Class
