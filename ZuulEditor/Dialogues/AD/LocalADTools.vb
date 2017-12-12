Imports System.DirectoryServices.AccountManagement
Imports System.Threading

Module LocalADTools
    Public domain As String = "as.internal"
    Public adUser As String = "ASBromcomADSyncer"
    Public adPass As String = "THw8DCzcPMPwqNC5zBUF"
    Public usersCTXString As String = "OU=AS Users, OU=Ashby School, DC=as, DC=Internal"

    Public userCTX As PrincipalContext = GetConnection("as.internal", usersCTXString)

    Public Function GetConnection(ByVal domain As String, ByVal OU As String) As PrincipalContext
        Return New PrincipalContext(ContextType.Domain, domain, OU, adUser, adPass)
    End Function

    Public Function UserExists(ByVal ctx As PrincipalContext, ByVal user As String) As Boolean
        Dim usr As UserPrincipal = UserPrincipal.FindByIdentity(ctx, user)
        If usr IsNot Nothing Then
            usr.Dispose()
            Return True
        Else
            Return False
        End If
    End Function

    Public Function GetUserPrincipalByID(ByRef ctx As PrincipalContext, ByRef admission As String) As DirectoryServices.AccountManagement.UserPrincipal
        Dim userList As New List(Of DirectoryServices.AccountManagement.UserPrincipal)
        Dim searchusr As DirectoryServices.AccountManagement.UserPrincipal = New DirectoryServices.AccountManagement.UserPrincipal(ctx)
        searchusr.EmployeeId = admission
        Dim searcher As PrincipalSearcher = New PrincipalSearcher(searchusr)
        For Each user As DirectoryServices.AccountManagement.UserPrincipal In searcher.FindAll()
            userList.Add(user)
        Next
        searcher.Dispose()
        If userList.Count > 1 Then
            Dim str As String = "Too many users with same id number - " & admission & vbCrLf
            For Each lusr In userList
                str = String.Format("{0}{1}{2}", str, ", ", lusr.SamAccountName)
            Next
            Throw New Exception(str)
            Return Nothing
        End If
        If userList.Count = 0 Then
            Return Nothing
        End If
        Return userList(0)
    End Function

    Public Function GetUserPrincipalexbyUsername(ByRef ctx As PrincipalContext, userName As String) As UserPrincipalex
        Try
            Dim usr As UserPrincipalex = UserPrincipalex.FindByIdentity(ctx, userName)
            Return usr
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function GetUserPrincipalsByFullName(ByRef ctx As PrincipalContext, fullname As String) As List(Of DirectoryServices.AccountManagement.UserPrincipal)
        Dim userlist As New List(Of DirectoryServices.AccountManagement.UserPrincipal)
        Dim searchusr As DirectoryServices.AccountManagement.UserPrincipal = New DirectoryServices.AccountManagement.UserPrincipal(ctx)
        searchusr.GivenName = fullname.Split(" "c)(0)
        searchusr.Surname = fullname.Split(" "c)(1)
        Dim searcher As PrincipalSearcher = New PrincipalSearcher(searchusr)
        For Each user As DirectoryServices.AccountManagement.UserPrincipal In searcher.FindAll()
            userlist.Add(user)
        Next
        searcher.Dispose()
        Return userlist
    End Function

    Public Function GetAllUsers(ByRef ctx As PrincipalContext) As List(Of UserPrincipalex)
        Dim userlist As New List(Of UserPrincipalex)
        Dim searchusr As UserPrincipalex = New UserPrincipalex(ctx)
        Dim searcher As PrincipalSearcher = New PrincipalSearcher(searchusr)
        For Each user As UserPrincipal In searcher.FindAll()
            userlist.Add(CType(user, UserPrincipalex))
        Next
        searcher.Dispose()
        searchusr.Dispose()
        Return userlist
    End Function

    Public Function GetAllComputers(ByRef ctx As PrincipalContext) As List(Of ComputerPrincipal)
        Dim computerList As New List(Of ComputerPrincipal)
        Try
            Dim searchComputer As ComputerPrincipal = New ComputerPrincipal(ctx)
            Dim searcher As PrincipalSearcher = New PrincipalSearcher(searchComputer)

            For Each computer As ComputerPrincipal In searcher.FindAll()
                computerList.Add(computer)
            Next
            searcher.Dispose()
            searchComputer.Dispose()
        Catch ex As Exception

        End Try

        Return computerList
    End Function
End Module


<DirectoryRdnPrefix("CN")>
<DirectoryObjectClass("Person")>
Public Class UserPrincipalex
    Inherits DirectoryServices.AccountManagement.UserPrincipal

    Public Sub New(context As PrincipalContext)
        MyBase.New(context)
    End Sub

    ' Implement the constructor with initialization parameters.
    Public Sub New(context As PrincipalContext, samAccountName As String, password As String, enabled As Boolean)
        MyBase.New(context, samAccountName, password, enabled)
    End Sub

    <DirectoryProperty("pager")>
    Public Property pager() As String
        Get
            If ExtensionGet("pager").Length <> 1 Then
                Return String.Empty
            End If
            Return DirectCast(ExtensionGet("pager")(0), String)
        End Get
        Set(value As String)
            ExtensionSet("pager", value)
        End Set
    End Property

    <DirectoryProperty("extensionAttribute1")>
    Public Property extensionAttribute1() As String
        Get
            If ExtensionGet("extensionAttribute1").Length <> 1 Then
                Return String.Empty
            End If
            Return DirectCast(ExtensionGet("extensionAttribute1")(0), String)
        End Get
        Set(value As String)
            ExtensionSet("extensionAttribute1", value)
        End Set
    End Property

    <DirectoryProperty("extensionAttribute2")>
    Public Property extensionAttribute2() As String
        Get
            If ExtensionGet("extensionAttribute2").Length <> 1 Then
                Return String.Empty
            End If
            Return DirectCast(ExtensionGet("extensionAttribute2")(0), String)
        End Get
        Set(value As String)
            ExtensionSet("extensionAttribute2", value)
        End Set
    End Property

    <DirectoryProperty("extensionAttribute3")>
    Public Property extensionAttribute3() As String
        Get
            If ExtensionGet("extensionAttribute3").Length <> 1 Then
                Return String.Empty
            End If
            Return DirectCast(ExtensionGet("extensionAttribute3")(0), String)
        End Get
        Set(value As String)
            ExtensionSet("extensionAttribute3", value)
        End Set
    End Property

    <DirectoryProperty("extensionAttribute4")>
    Public Property extensionAttribute4() As String
        Get
            If ExtensionGet("extensionAttribute4").Length <> 1 Then
                Return String.Empty
            End If
            Return DirectCast(ExtensionGet("extensionAttribute4")(0), String)
        End Get
        Set(value As String)
            ExtensionSet("extensionAttribute4", value)
        End Set
    End Property

    <DirectoryProperty("extensionAttribute5")>
    Public Property extensionAttribute5() As String
        Get
            If ExtensionGet("extensionAttribute5").Length <> 1 Then
                Return String.Empty
            End If
            Return DirectCast(ExtensionGet("extensionAttribute5")(0), String)
        End Get
        Set(value As String)
            ExtensionSet("extensionAttribute5", value)
        End Set
    End Property

    <DirectoryProperty("profilePath")>
    Public Property ProfilePath() As String
        Get
            If ExtensionGet("profilePath").Length <> 1 Then
                Return String.Empty
            End If

            Return DirectCast(ExtensionGet("profilePath")(0), String)
        End Get
        Set(value As String)
            ExtensionSet("profilePath", value)
        End Set
    End Property

    Public Property Department() As String
        Get
            If ExtensionGet("department").Length <> 1 Then
                Return String.Empty
            End If

            Return DirectCast(ExtensionGet("department")(0), String)
        End Get
        Set(value As String)
            ExtensionSet("department", value)
        End Set
    End Property

    ' Implement the overloaded search method FindByIdentity.
    Public Shared Shadows Function FindByIdentity(context As PrincipalContext, identityValue As String) As UserPrincipalex
        Try
            Return DirectCast(FindByIdentityWithType(context, GetType(UserPrincipalex), identityValue), UserPrincipalex)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    ' Implement the overloaded search method FindByIdentity.
    Public Shared Shadows Function FindByIdentity(context As PrincipalContext, identityType As IdentityType, identityValue As String) As UserPrincipalex
        Try
            Return DirectCast(FindByIdentityWithType(context, GetType(UserPrincipalex), identityType, identityValue), UserPrincipalex)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

End Class
