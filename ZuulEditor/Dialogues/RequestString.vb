Public Class RequestString
    Public Sub New(ByVal prompt As String, ByVal Optional title As String = "", ByVal Optional requestWidth As Integer = 100)

        ' This call is required by the designer.
        InitializeComponent()
        Me.Text = title
        PromptLabel.Text = prompt
        Me.Width = requestWidth

    End Sub

    Private Sub RequestString_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        ResultTextBox.Focus()
    End Sub

    Private Sub ResultTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles ResultTextBox.KeyDown
        If e.KeyCode = Keys.Return Then
            Me.DialogResult = DialogResult.OK
        End If
    End Sub
End Class