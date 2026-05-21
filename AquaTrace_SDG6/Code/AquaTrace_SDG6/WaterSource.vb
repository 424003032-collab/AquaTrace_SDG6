Public Class WaterSource

    ' ── PRIVATE FIELDS ───────────────────────────────────
    Private _sourceID As Integer
    Private _sourceName As String
    Private _location As String
    Private _sourceType As String
    Private _status As String
    Private _coverageHH As Integer
    Private _lastInspected As DateTime

    ' ── PUBLIC PROPERTIES ────────────────────────────────
    Public Property SourceID As Integer
        Get
            Return _sourceID
        End Get
        Set(value As Integer)
            _sourceID = value
        End Set
    End Property

    Public Property SourceName As String
        Get
            Return _sourceName
        End Get
        Set(value As String)
            _sourceName = value
        End Set
    End Property

    Public Property Location As String
        Get
            Return _location
        End Get
        Set(value As String)
            _location = value
        End Set
    End Property

    Public Property SourceType As String
        Get
            Return _sourceType
        End Get
        Set(value As String)
            _sourceType = value
        End Set
    End Property

    Public Property Status As String
        Get
            Return _status
        End Get
        Set(value As String)
            _status = value
        End Set
    End Property

    Public Property CoverageHH As Integer
        Get
            Return _coverageHH
        End Get
        Set(value As Integer)
            _coverageHH = value
        End Set
    End Property

    Public Property LastInspected As DateTime
        Get
            Return _lastInspected
        End Get
        Set(value As DateTime)
            _lastInspected = value
        End Set
    End Property

    ' ── METHOD: GetStatusSummary ──────────────────────────
    ' Returns a descriptive status string for reporting
    Public Function GetStatusSummary() As String
        Select Case _status
            Case "Active"
                Return "✔ Active — Fully operational"
            Case "Needs Repair"
                Return "⚠ Needs Repair — Requires maintenance"
            Case "Inactive"
                Return "✘ Inactive — Not operational"
            Case Else
                Return _status
        End Select
    End Function

    ' ── METHOD: GetCoverageLevel ──────────────────────────
    ' Returns coverage level based on households served
    Public Function GetCoverageLevel() As String
        If _coverageHH >= 200 Then
            Return "High Coverage"
        ElseIf _coverageHH >= 100 Then
            Return "Medium Coverage"
        Else
            Return "Low Coverage"
        End If
    End Function

End Class

