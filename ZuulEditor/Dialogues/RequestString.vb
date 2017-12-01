Public Class RequestString
    Public Sub New(ByVal prompt As String, ByVal Optional title As String = "", ByVal Optional requestWidth As Integer = 100)

        ' This call is required by the designer.
        InitializeComponent()
        Me.Text = title
        PromptLabel.Text = prompt
        Me.Width = requestWidth

    End Sub

End Class