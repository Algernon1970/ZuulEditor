<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportFromAD
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
        Me.ImportProgress = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ADTreeView = New System.Windows.Forms.TreeView()
        Me.SelectedADPathLabel = New System.Windows.Forms.Label()
        Me.ImportButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ImportProgress
        '
        Me.ImportProgress.Location = New System.Drawing.Point(98, 178)
        Me.ImportProgress.Name = "ImportProgress"
        Me.ImportProgress.Size = New System.Drawing.Size(377, 13)
        Me.ImportProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ImportProgress.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Import Progress"
        '
        'ADTreeView
        '
        Me.ADTreeView.Location = New System.Drawing.Point(15, 25)
        Me.ADTreeView.Name = "ADTreeView"
        Me.ADTreeView.Size = New System.Drawing.Size(332, 147)
        Me.ADTreeView.TabIndex = 2
        '
        'SelectedADPathLabel
        '
        Me.SelectedADPathLabel.AutoSize = True
        Me.SelectedADPathLabel.Location = New System.Drawing.Point(12, 9)
        Me.SelectedADPathLabel.Name = "SelectedADPathLabel"
        Me.SelectedADPathLabel.Size = New System.Drawing.Size(69, 13)
        Me.SelectedADPathLabel.TabIndex = 3
        Me.SelectedADPathLabel.Text = "AshbySchool"
        '
        'ImportButton
        '
        Me.ImportButton.Location = New System.Drawing.Point(382, 138)
        Me.ImportButton.Name = "ImportButton"
        Me.ImportButton.Size = New System.Drawing.Size(93, 34)
        Me.ImportButton.TabIndex = 4
        Me.ImportButton.Text = "Import From AD"
        Me.ImportButton.UseVisualStyleBackColor = True
        '
        'Import
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 200)
        Me.Controls.Add(Me.ImportButton)
        Me.Controls.Add(Me.SelectedADPathLabel)
        Me.Controls.Add(Me.ADTreeView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ImportProgress)
        Me.Name = "Import"
        Me.Text = "ImportComputers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ImportProgress As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents ADTreeView As TreeView
    Friend WithEvents SelectedADPathLabel As Label
    Friend WithEvents ImportButton As Button
End Class
