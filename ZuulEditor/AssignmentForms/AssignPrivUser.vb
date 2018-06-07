Public Class AssignPrivUser

    Dim Lnk_PrivUsers As New ZuulDataSetTableAdapters.Lnk_ComputerPersonTableAdapter
    Private Sub AssignPrivUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'TODO: This line of code loads data into the 'ZuulDataSet.Tbl_Computer' table. You can move, or remove it, as needed.
        Me.Tbl_ComputerTableAdapter.Fill(Me.ZuulDataSet.Tbl_Computer)
        'TODO: This line of code loads data into the 'ZuulDataSet.Tbl_Person' table. You can move, or remove it, as needed.
        Me.Tbl_PersonTableAdapter.Fill(Me.ZuulDataSet.Tbl_Person)

    End Sub

    Private Sub ComputerFilterBox_TextChanged(sender As Object, e As EventArgs) Handles ComputerFilterBox.TextChanged
        'Me.Tbl_ComputerTableAdapter.FillByPartialName(Me.ZuulDataSet.Tbl_Computer, ComputerFilterBox.Text & "%")
        TblComputerBindingSource.Filter = "[Name] like '" & ComputerFilterBox.Text & "%'"
    End Sub

    Private Sub UserFilterBox_TextChanged(sender As Object, e As EventArgs) Handles UserFilterBox.TextChanged
        'Me.Tbl_PersonTableAdapter.FillByPartial(Me.ZuulDataSet.Tbl_Person, "%" & UserFilterBox.Text & "%")
        TblPersonBindingSource.Filter = "[SamAccount] like '" & UserFilterBox.Text & "%'"
    End Sub

    Private Sub AssignPrivButton_Click(sender As Object, e As EventArgs) Handles AssignPrivButton.Click
        Dim computer As DataRow
        Dim person As DataRow
        OperationListBox.Items.Clear()

        For Each computerView As DataRowView In ComputerListBox.SelectedItems
            computer = computerView.Row
            OperationListBox.Items.Add(computer.Field(Of String)("Name"))
            For Each personView As DataRowView In UserListBox.SelectedItems
                person = personView.Row
                If Lnk_PrivUsers.AlreadyAssigned(computer.Field(Of Integer)("ComputerID"), person.Field(Of Integer)("PersonID")) = 0 Then
                    Lnk_PrivUsers.AssignPriv(computer.Field(Of Integer)("ComputerID"), person.Field(Of Integer)("PersonID"))
                End If
                OperationListBox.Items.Add(vbTab & person.Field(Of String)("SamAccount"))
            Next
        Next
    End Sub

    Private Sub UnassignPrivButton_Click(sender As Object, e As EventArgs) Handles UnassignPrivButton.Click
        Dim theSam As String = ""
        Dim theComputer As String = ""
        For Each index As Integer In OperationListBox.SelectedIndices
            'get item at index.  Does index start with tab. If so, loop backwards till one doesnt.  This is the Machine.
            Dim item As String = OperationListBox.Items(index).ToString
            If item.StartsWith(vbTab) Then
                theSam = item.Replace(vbTab, "")
                For x = index To 0 Step -1
                    item = OperationListBox.Items(x).ToString
                    If Not item.StartsWith(vbTab) Then
                        theComputer = item
                        Exit For
                    End If
                Next
            End If

            Dim cid As Integer? = Tbl_ComputerTableAdapter.GetCIDbyName(theComputer)
            Dim pid As Integer? = Tbl_PersonTableAdapter.GetPIDbySAM(theSam)
            If (IsNothing(cid)) Or (IsNothing(pid)) Then
                OperationListBox.Items.Add(String.Format("Failed to Remove {0} from {1}", theSam, theComputer))
            Else
                OperationListBox.Items.Add(String.Format("Removed {0} from {1}", theSam, theComputer))
                Lnk_PrivUsers.DeleteAssignment(CType(cid, Integer), CType(pid, Integer))
            End If

        Next
    End Sub

    Private Sub ComputerListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComputerListBox.SelectedIndexChanged
        OperationListBox.Items.Clear()
        Dim computer As DataRow
        Dim user As DataRow
        For Each computerView As DataRowView In ComputerListBox.SelectedItems
            computer = computerView.Row
            OperationListBox.Items.Add(computer.Field(Of String)("Name"))
            For Each person As DataRow In Lnk_PrivUsers.GetDataByComputer(computer.Field(Of Integer)("ComputerID"))
                user = Tbl_PersonTableAdapter.GetDataByID(person.Field(Of Integer)("PersonID"))(0)
                OperationListBox.Items.Add(vbTab & user.Field(Of String)("SamAccount"))
            Next
        Next
    End Sub
End Class