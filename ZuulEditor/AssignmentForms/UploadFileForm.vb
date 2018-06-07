Public Class UploadFileForm
    Private Sub UploadFileForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ZuulDataSet.Tbl_Files' table. You can move, or remove it, as needed.
        Me.Tbl_FilesTableAdapter.Fill(Me.ZuulDataSet.Tbl_Files)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 1 Then DoDownload(DataGridView1.Rows(e.RowIndex))
        If e.ColumnIndex = 2 Then DoUpload(DataGridView1.Rows(e.RowIndex))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CreateItemButton.Click
        Dim req As New RequestString("Title", "File Table")
        Dim res As DialogResult = req.ShowDialog()
        If res = DialogResult.OK Then
            DoInsert(req.ResultTextBox.Text)
        End If
        req.Dispose()
    End Sub

    Private Sub DoDownload(ByRef dg As DataGridViewRow)
        Dim dbi As DataRowView = DirectCast(dg.DataBoundItem, DataRowView)
        Dim dbr As DataRow = dbi.Row

        Dim rowID As Integer = dbr.Field(Of Integer)("ID")
        Dim fn As String = dbr.Field(Of String)("OriginalFN")
        Dim content As Byte() = dbr.Field(Of Byte())("Data")
        Dim fnext As String = fn.Split("."c)(1)
        SaveFileDialog1.DefaultExt = fnext
        SaveFileDialog1.Filter = String.Format("*.{0}|*.{0}", fnext)
        SaveFileDialog1.AddExtension = True
        SaveFileDialog1.FileName = fn
        Dim res As DialogResult = SaveFileDialog1.ShowDialog
        If res = DialogResult.OK Then
            Dim loc As String = SaveFileDialog1.FileName
            Dim outStream As IO.Stream = SaveFileDialog1.OpenFile()
            outStream.Write(content, 0, content.Length)
            outStream.Flush()
            outStream.Close()
        End If
    End Sub

    Private Sub DoUpload(ByRef dg As DataGridViewRow)
        Dim dbi As DataRowView = DirectCast(dg.DataBoundItem, DataRowView)
        Dim dbr As DataRow = dbi.Row

        Dim rowID As Integer = dbr.Field(Of Integer)("ID")

        Dim res As DialogResult = OpenFileDialog1.ShowDialog
        If res = DialogResult.OK Then
            Dim fn As IO.Stream = OpenFileDialog1.OpenFile
            Dim contents = GetStreamAsByteArray(fn)
            Dim filedb As New ZuulDataSetTableAdapters.Tbl_FilesTableAdapter
            filedb.UpdateQuery(contents, OpenFileDialog1.SafeFileName, rowID)
        End If

    End Sub



    Private Sub DoInsert(ByVal title As String)
        Dim fileDB As New ZuulDataSetTableAdapters.Tbl_FilesTableAdapter
        fileDB.InsertQuery(title)
    End Sub

    Private Function GetStreamAsByteArray(ByRef stream As IO.Stream) As Byte()
        Dim sl As Integer = Convert.ToInt32(stream.Length)
        Dim filedata As Byte() = New Byte(sl) {}
        stream.Read(filedata, 0, sl)
        stream.Flush()
        stream.Close()
        Return filedata
    End Function
End Class