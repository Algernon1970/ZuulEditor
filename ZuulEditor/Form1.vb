Public Class Form1
    Private Sub PrinterAssignButton_Click(sender As Object, e As EventArgs) Handles PrinterAssignButton.Click
        Dim screen As New AssignPrintersForm
        screen.ShowDialog()
    End Sub
End Class
