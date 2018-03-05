Imports System.DirectoryServices
Imports System.DirectoryServices.AccountManagement

Public Class Import
    Dim OptType As New Importer
    Dim OUS As New TreeNode("Internal")
    Dim ParentNode As TreeNode
    Public ComputerTableAdapter As New ZuulDataSetTableAdapters.Tbl_ComputerTableAdapter
    Public PersonTableAdapter As New ZuulDataSetTableAdapters.Tbl_PersonTableAdapter

    Public Sub New(ByVal opt As Importer)

        ' This call is required by the designer.
        InitializeComponent()
        OptType = opt
        If opt = Importer.computers Then
            Me.Text = "Import Computers"
        Else
            Me.Text = "Import Users"
        End If
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub ImportComputers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ADTreeView.Nodes.AddRange(New TreeNode() {OUS})

        Dim ldap As New DirectoryEntry("LDAP://" + Environment.GetEnvironmentVariable("USERDNSDOMAIN"))
        Dim LDAPChildren As DirectoryEntries
        LDAPChildren = ldap.Children
        ParentNode = OUS

        FillTreeView(ldap, LDAPChildren)
    End Sub

    Private Sub FillTreeView(ByVal LDAPEntry As DirectoryEntry, ByVal LDAPEntries As DirectoryEntries)
        Dim newNode As New TreeNode(GetName(LDAPEntry.Name)) With {
            .Tag = LDAPEntry.Path
        }
        Try
            ParentNode.Nodes.Add(newNode)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            For Each LDAPEntry In LDAPEntries
                Select Case LDAPEntry.SchemaClassName.ToString
                    Case "organizationalUnit"
                        ParentNode = newNode
                        FillTreeView(LDAPEntry, LDAPEntry.Children)
                End Select
            Next

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Function GetName(ByVal strName As String) As String
        Dim pos As Integer
        pos = strName.IndexOf("=")
        GetName = strName.Substring(pos + 1)
    End Function

    Private Sub ADTreeView_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles ADTreeView.AfterSelect
        Dim node As String = e.Node.FullPath
        SelectedADPathLabel.Text = node
    End Sub

    Private Sub ImportButton_Click(sender As Object, e As EventArgs) Handles ImportButton.Click
        Dim node As String = SelectedADPathLabel.Text
        If Not node.Equals("Internal") Then
            Dim adPath As String = PathToOU(node)
            If OptType = Importer.computers Then
                ImportComputers(adPath)
            Else
                ImportUsers(adPath)
            End If
        End If
    End Sub

    Private Sub ImportComputers(ByVal path As String)
        path = path.Replace("Internal\as\", "")
        Dim ctx As PrincipalContext = GetConnection(domain, path)
        Dim cList As List(Of ComputerPrincipal) = GetAllComputers(ctx)
        ImportProgress.Maximum = cList.Count
        ImportProgress.Value = 0
        For Each computer As ComputerPrincipal In cList
            ImportProgress.Increment(1)
            AddComputerToDB(computer)
        Next
    End Sub

    Private Sub ImportUsers(ByVal path As String)
        path = path.Replace("Internal\as\", "")
        Dim ctx As PrincipalContext = GetConnection(domain, path)
        Dim pList As List(Of UserPrincipalex) = GetAllUsers(ctx)
        ImportProgress.Maximum = pList.Count
        ImportProgress.Value = 0
        For Each person As UserPrincipalex In pList
            ImportProgress.Increment(1)
            AddPersonToDB(person)
        Next
    End Sub

    Private Sub AddComputerToDB(ByRef computer As ComputerPrincipal)
        Dim cnt As Integer = CType(ComputerTableAdapter.alreadyExists(computer.Name), Integer)
        If cnt = 0 Then
            ComputerTableAdapter.CreateComputer(computer.Name, "0", "0", "", "", 0, 0, False, 1, 1, "0", "0", Now.ToShortDateString, 0, False, computer.DistinguishedName)
        End If
    End Sub


    Private Sub AddPersonToDB(ByRef person As UserPrincipalex)
        If person.Enabled Then
            Dim cnt As Integer = CType(PersonTableAdapter.SamExists(person.SamAccountName), Integer)
            If cnt = 0 Then
                PersonTableAdapter.CreateUser(person.GivenName, person.Surname, person.SamAccountName, person.Sid.ToString, person.UserPrincipalName, person.EmployeeId)
            Else
                PersonTableAdapter.UpdateUser(person.GivenName, person.Surname, person.Sid.ToString, person.DistinguishedName, person.EmployeeId, person.SamAccountName)
            End If
        End If

    End Sub

End Class

Public Enum Importer
    users
    computers
End Enum
