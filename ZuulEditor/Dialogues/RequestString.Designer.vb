<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RequestString
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.MyCancelButton = New System.Windows.Forms.Button()
        Me.PromptLabel = New System.Windows.Forms.Label()
        Me.ResultTextBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.PromptLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ResultTextBox, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(478, 115)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.OKButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.MyCancelButton)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 83)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(472, 29)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'OKButton
        '
        Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OKButton.Location = New System.Drawing.Point(389, 3)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(80, 26)
        Me.OKButton.TabIndex = 0
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'MyCancelButton
        '
        Me.MyCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.MyCancelButton.Location = New System.Drawing.Point(303, 3)
        Me.MyCancelButton.Name = "MyCancelButton"
        Me.MyCancelButton.Size = New System.Drawing.Size(80, 26)
        Me.MyCancelButton.TabIndex = 1
        Me.MyCancelButton.Text = "Cancel"
        Me.MyCancelButton.UseVisualStyleBackColor = True
        '
        'PromptLabel
        '
        Me.PromptLabel.AutoSize = True
        Me.PromptLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PromptLabel.Location = New System.Drawing.Point(3, 0)
        Me.PromptLabel.Name = "PromptLabel"
        Me.PromptLabel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 15)
        Me.PromptLabel.Size = New System.Drawing.Size(472, 45)
        Me.PromptLabel.TabIndex = 1
        Me.PromptLabel.Text = "Label1"
        Me.PromptLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ResultTextBox
        '
        Me.ResultTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResultTextBox.Location = New System.Drawing.Point(3, 48)
        Me.ResultTextBox.Name = "ResultTextBox"
        Me.ResultTextBox.Size = New System.Drawing.Size(472, 20)
        Me.ResultTextBox.TabIndex = 2
        Me.ResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RequestString
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 115)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "RequestString"
        Me.ShowIcon = False
        Me.Text = "RequestString"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents OKButton As Button
    Friend WithEvents MyCancelButton As Button
    Friend WithEvents PromptLabel As Label
    Friend WithEvents ResultTextBox As TextBox
End Class
