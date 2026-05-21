Public Class User

    ' ── PRIVATE FIELDS ───────────────────────────────────
    Private _userID As Integer
    Private _username As String
    Private _password As String
    Private _role As String
    Private _fullName As String

    ' ── PUBLIC PROPERTIES ────────────────────────────────
    Public Property UserID As Integer
        Get
            Return _userID
        End Get
        Set(value As Integer)
            _userID = value
        End Set
    End Property

    Public Property Username As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property

    Public Property Role As String
        Get
            Return _role
        End Get
        Set(value As String)
            _role = value
        End Set
    End Property

    Public Property FullName As String
        Get
            Return _fullName
        End Get
        Set(value As String)
            _fullName = value
        End Set
    End Property

    ' ── METHOD: IsAdmin ───────────────────────────────────
    ' Returns True if user has Admin role
    Public Function IsAdmin() As Boolean
        Return _role = "Admin"
    End Function

    ' ── METHOD: GetWelcomeMessage ─────────────────────────
    ' Returns a personalized welcome message
    Public Function GetWelcomeMessage() As String
        Return "Welcome, " & _fullName & " (" & _role & ")"
    End Function

End Class

