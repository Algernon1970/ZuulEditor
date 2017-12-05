Public Class Form1
    Private Sub PrinterAssignButton_Click(sender As Object, e As EventArgs) Handles PrinterAssignButton.Click
        Dim screen As New AssignPrintersForm
        screen.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim screen As New PrinterDetail
        screen.Show()
    End Sub
End Class
