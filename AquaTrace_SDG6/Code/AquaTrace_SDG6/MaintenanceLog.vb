Public Class MaintenanceLog

    ' ── PRIVATE FIELDS ───────────────────────────────────
    Private _logID As Integer
    Private _sourceID As Integer
    Private _maintenanceDate As DateTime
    Private _technicianName As String
    Private _issueDescription As String
    Private _actionTaken As String
    Private _cost As Decimal

    ' ── PUBLIC PROPERTIES ────────────────────────────────
    Public Property LogID As Integer
        Get
            Return _logID
        End Get
        Set(value As Integer)
            _logID = value
        End Set
    End Property

    Public Property SourceID As Integer
        Get
            Return _sourceID
        End Get
        Set(value As Integer)
            _sourceID = value
        End Set
    End Property

    Public Property MaintenanceDate As DateTime
        Get
            Return _maintenanceDate
        End Get
        Set(value As DateTime)
            _maintenanceDate = value
        End Set
    End Property

    Public Property TechnicianName As String
        Get
            Return _technicianName
        End Get
        Set(value As String)
            _technicianName = value
        End Set
    End Property

    Public Property IssueDescription As String
        Get
            Return _issueDescription
        End Get
        Set(value As String)
            _issueDescription = value
        End Set
    End Property

    Public Property ActionTaken As String
        Get
            Return _actionTaken
        End Get
        Set(value As String)
            _actionTaken = value
        End Set
    End Property

    Public Property Cost As Decimal
        Get
            Return _cost
        End Get
        Set(value As Decimal)
            _cost = value
        End Set
    End Property

    ' ── METHOD: GetCostLevel ─────────────────────────────
    ' Categorizes maintenance cost level
    Public Function GetCostLevel() As String
        If _cost >= 10000 Then
            Return "High Cost"
        ElseIf _cost >= 5000 Then
            Return "Medium Cost"
        Else
            Return "Low Cost"
        End If
    End Function

    ' ── METHOD: GetFormattedCost ──────────────────────────
    Public Function GetFormattedCost() As String
        Return "₱" & _cost.ToString("N2")
    End Function

End Class

