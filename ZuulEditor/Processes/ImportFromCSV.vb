Imports System.IO
Imports KBCsv

Public Class ImportFromCSV
    Dim OptType As New Importer

    Public Sub New(ByVal opt As Importer)
        InitializeComponent()
        OptType = opt
        Select Case OptType
            Case Importer.privs
                Me.Text = "Assign Priv Users"
                CSVBrowser.Title = "Priv Users"
            Case Importer.assignPrinters
                Me.Text = "Assign Printers to Computers"
                CSVBrowser.Title = "Printers to Computers"
            Case Importer.printerDetails
                Me.Text = "Update Printer Details"
                CSVBrowser.Title = "Printer Details"
            Case Importer.computerDetails
                Me.Text = "Update Computer Details"
                CSVBrowser.Title = "Computer Details"
        End Select
    End Sub

    Private Sub ImportButton_Click(sender As Object, e As EventArgs) Handles ImportButton.Click
        Dim res = CSVBrowser.ShowDialog
        If res = DialogResult.OK Then
            ImportButton.Enabled = False
            ProcessImport(CSVBrowser.FileName)
            ImportButton.Enabled = True
        End If
    End Sub

    ''' <summary>
    ''' Step through CSV and import into the relevent tables
    ''' Status : Working
    ''' </summary>
    ''' <param name="fn">Filename of the CSV to import</param>
    Private Sub ProcessImport(ByRef fn As String)
        Dim record As DataRecord

        Dim max As Integer = CountRecords(fn)
        ImportProgress.Maximum = max
        ImportProgress.Value = 0
        ImportProgress.Step = 1
        Using sr As New StreamReader(fn)
            Using csv As New CsvReader(sr)
                csv.ReadHeaderRecord()

                While csv.HasMoreRecords
                    record = csv.ReadDataRecord

                    Select Case OptType
                        Case Importer.privs
                            RecordPriv(record)
                        Case Importer.assignPrinters
                            AssignPrinterbyCSVRecord(record)
                        Case Importer.computerDetails
                            UpdateComputerDetails(record)
                        Case Importer.printerDetails
                            UpdatePrinterDetails(record)
                    End Select
                    ImportProgress.PerformStep()
                End While
            End Using
        End Using
    End Sub

    ''' <summary>
    ''' Count records in a CSV to use to set progress bar maximum
    ''' </summary>
    ''' <param name="fn">Filename of the CSV</param>
    ''' <returns></returns>
    Private Function CountRecords(ByVal fn As String) As Integer
        Dim count As Integer = 0
        Using sr As New StreamReader(fn)
            Using csv As New CsvReader(sr)
                csv.ReadHeaderRecord()

                While csv.HasMoreRecords
                    csv.ReadDataRecord()
                    count = count + 1
                End While
            End Using
        End Using
        Return count
    End Function

    ''' <summary>
    ''' Assign priv user to a computer based on CSV record
    ''' </summary>
    ''' <param name="record">Record from CSV</param>
    Public Sub RecordPriv(ByRef record As DataRecord)
        Dim crow As DataRow = Nothing
        Dim urow As DataRow = Nothing
        Try
            crow = Tbl_ComputerTableAdapter1.GetComputerByName(record("ComputerName").ToString)(0)
            urow = Tbl_PersonTableAdapter1.GetByPartial(record("User").ToString)(0)
        Catch ex As Exception
            Outbox.AppendText(String.Format("Error: {0} - {1},{2}{3}", ex.Message, record("ComputerName").ToString, record("User").ToString, vbCrLf))
            Return
        End Try

        If IsNothing(crow) Then
            Outbox.AppendText(String.Format("Computer {0} not found in DB{1}", record("ComputerName").ToString, vbCrLf))
            Return
        End If
        If IsNothing(urow) Then
            Outbox.AppendText(String.Format("User {0} not found in DB{1}", record("UserName").ToString, vbCrLf))
            Return
        End If
        Dim cid As Integer = crow.Field(Of Integer)("ComputerID")
        Dim uid As Integer = urow.Field(Of Integer)("PersonID")
        If Lnk_ComputerPersonTableAdapter1.AlreadyAssigned(cid, uid) > 0 Then
            Outbox.AppendText(String.Format("Already Assigned {0} To {1}{2}", record("User").ToString, record("ComputerName").ToString, vbCrLf))
        Else
            Lnk_ComputerPersonTableAdapter1.AssignPriv(cid, uid)
            Outbox.AppendText(String.Format("Assigned {0} To {1}{2}", record("User").ToString, record("ComputerName").ToString, vbCrLf))
        End If
    End Sub

    ''' <summary>
    ''' Assign a printer to a computer based on a CSV record
    ''' Status : Working
    ''' </summary>
    ''' <param name="record">CSV Record</param>
    Public Sub AssignPrinterbyCSVRecord(ByRef record As DataRecord)
        Dim crow As DataRow = Tbl_ComputerTableAdapter1.GetComputerByName(record("ComputerName").ToString)(0)
        Dim prow As DataRow = Tbl_PrinterTableAdapter1.GetPrinterByName(record("PrinterName").ToString)(0)
        If IsNothing(crow) Then
            Outbox.AppendText(String.Format("Computer {0} not found in DB{1}", record("ComputerName").ToString, vbCrLf))
            Return
        End If
        If IsNothing(prow) Then
            Outbox.AppendText(String.Format("User {0} not found in DB{1}", record("PrinterName").ToString, vbCrLf))
            Return
        End If
        Dim cid As Integer = crow.Field(Of Integer)("ComputerID")
        Dim uid As Integer = prow.Field(Of Integer)("PrinterID")

        If Lnk_ComputerPrinterTableAdapter1.AlreadyAssigned(cid, uid) > 0 Then
            Lnk_ComputerPrinterTableAdapter1.Insert(cid, uid, If(record("Default").ToString.ToLower.Equals("true"), True, False))
            Outbox.AppendText(String.Format("Assigned {0} To {1}{2}", record("PrinterName").ToString, record("ComputerName").ToString, vbCrLf))
        Else
            Outbox.AppendText(String.Format("Found {0} To {1}{2}", record("PrinterName").ToString, record("ComputerName").ToString, vbCrLf))
        End If
    End Sub

    ''' <summary>
    ''' Update Database from CSV Record
    ''' Status : Working
    ''' </summary>
    ''' <param name="record">CSV Record</param>
    ''' 
    Private Sub UpdatePrinterDetails(ByRef record As DataRecord)
        Dim locationNumber As Integer = GetLocationNumber(record)
        Dim supplierNumber As Integer = GetSupplierNumber(record)

        If Tbl_PrinterTableAdapter1.alreadyExists(record("PrinterName")) > 0 Then
            Dim pid As Integer = Tbl_PrinterTableAdapter1.GetPrinterByName(record("PrinterName"))(0).Field(Of Integer)("PrinterID")
            'Update existing record
            Tbl_PrinterTableAdapter1.UpdatePrinterByID(record("PrinterName"), record("ConnectionString"), record("Make"), record("Model"), record("IPAddress"), locationNumber, supplierNumber, Decimal.Parse((record("PurchaseCost"))), record("PurchaseDate"), False, record("Inventory"), record("SerialNo"), pid)
        Else
            'Create new record
            Tbl_PrinterTableAdapter1.CreateFullPrinter(record("PrinterName"), record("ConnectionString"), record("Make"), record("Model"), record("IPAddress"), locationNumber, supplierNumber, Decimal.Parse((record("PurchaseCost"))), record("PurchaseDate"), False, record("Inventory"), record("SerialNo"))
        End If
    End Sub

    Private Sub UpdateComputerDetails(ByRef record As DataRecord)
        Dim locationNumber As Integer = GetLocationNumber(record)
        Dim supplierNumber As Integer = GetSupplierNumber(record)

        If Tbl_ComputerTableAdapter1.alreadyExists(record("Computer Name")) > 0 Then
            Dim cid As Integer = Tbl_ComputerTableAdapter1.GetComputerByName(record("Computer Name"))(0).Field(Of Integer)("ComputerID")
            'updatecomputerbyid
            Tbl_ComputerTableAdapter1.UpdateDetails(record("Computer Name"), "", record("Computer Serial Number"), record("Computer Processor Name"), record("Computer AD Path"), False, 0, "1/1/1970", "", record("Computer MAC Address"), supplierNumber, locationNumber, False, 0, Integer.Parse(record("Computer Memory").Replace(" GB", "")), record("Computer Model"), record("Computer Manufacturer"), cid)
        Else
            'createnewrecord
            Tbl_ComputerTableAdapter1.CreateComputer(record("Computer Name"), "", record("Computer Serial Number"), record("Computer Manufacturer"), record("Computer Model"), Integer.Parse(record("Computer Memory").Replace(" GB", "")), 0, False, locationNumber, supplierNumber, record("Computer MAC Address"), "", "1/1/1970", 0, False, record("Computer AD Path"), record("Computer Processor Name"))
        End If

    End Sub

    Private Function GetSupplierNumber(record As DataRecord) As Integer
        Dim supplierNumber As Integer = 1
        If Tbl_SupplierTableAdapter1.AlreadyExists(record("SupplierName")) > 0 Then
            supplierNumber = Tbl_SupplierTableAdapter1.GetIDByName(record("SupplierName"))(0).Field(Of Integer)("SupplierID")
        Else
            Tbl_SupplierTableAdapter1.CreateSupplier(record("SupplierName"), "", "")
            supplierNumber = Tbl_SupplierTableAdapter1.GetIDByName(record("SupplierName"))(0).Field(Of Integer)("SupplierID")
            If Not supplierNumber > 1 Then supplierNumber = 1
        End If

        Return supplierNumber
    End Function

    Private Function GetLocationNumber(record As DataRecord) As Integer
        Dim locationNumber As Integer = 1
        If Tbl_LocationTableAdapter1.AlreadyExists(record("LocationName")) > 0 Then
            locationNumber = Tbl_LocationTableAdapter1.GetIDByName(record("LocationName"))(0).Field(Of Integer)("LocationID")
        Else
            Tbl_LocationTableAdapter1.CreateLocation(record("LocationName"))
            locationNumber = Tbl_LocationTableAdapter1.GetIDByName(record("LocationName"))(0).Field(Of Integer)("LocationID")
            If Not locationNumber > 1 Then locationNumber = 1
        End If

        Return locationNumber
    End Function
End Class