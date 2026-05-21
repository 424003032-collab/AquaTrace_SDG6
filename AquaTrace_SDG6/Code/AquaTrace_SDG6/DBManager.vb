Imports Microsoft.Data.SqlClient
Imports System.Data

Public Class DBManager

    ' ── LoginUser ─────────────────────────────────────────
    ' Validates username and password against Users table.
    ' Returns a User object if found, Nothing if not found.
    Public Shared Function LoginUser(username As String,
                                     password As String) As User
        Try
            Using conn As SqlConnection = ConnectionClass.GetConnection()
                conn.Open()
                Dim query As String =
                    "SELECT * FROM Users WHERE Username = @user
                     AND Password = @pass"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@user", username)
                    cmd.Parameters.AddWithValue("@pass", password)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim user As New User()
                            user.UserID = Convert.ToInt32(reader("UserID"))
                            user.Username = reader("Username").ToString()
                            user.Password = reader("Password").ToString()
                            user.Role = reader("Role").ToString()
                            user.FullName = reader("FullName").ToString()
                            Return user
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Login error: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
        Return Nothing
    End Function

    ' ── LoadWaterSources ──────────────────────────────────
    ' Loads all water sources into a DataTable.
    ' Accepts optional search string for live search.
    Public Shared Function LoadWaterSources(
                           Optional search As String = "") As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As SqlConnection = ConnectionClass.GetConnection()
                conn.Open()
                Dim query As String
                If String.IsNullOrWhiteSpace(search) Then
                    query = "SELECT * FROM WaterSources ORDER BY SourceID"
                Else
                    query = "SELECT * FROM WaterSources
                             WHERE SourceName LIKE @search
                             OR Location LIKE @search
                             OR Status LIKE @search
                             ORDER BY SourceID"
                End If
                Using cmd As New SqlCommand(query, conn)
                    If Not String.IsNullOrWhiteSpace(search) Then
                        cmd.Parameters.AddWithValue("@search",
                                                    "%" & search & "%")
                    End If
                    Using adapter As New SqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading water sources: " & ex.Message,
                            "Load Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    ' ── InsertWaterSource ─────────────────────────────────
    ' Inserts a new water source using parameterized query.
    ' Returns True if successful, False if not.
    Public Shared Function InsertWaterSource(
                           source As WaterSource) As Boolean
        Try
            Using conn As SqlConnection = ConnectionClass.GetConnection()
                conn.Open()
                Dim query As String =
                    "INSERT INTO WaterSources
                     (SourceName, Location, SourceType,
                      Status, CoverageHH, LastInspected)
                     VALUES
                     (@name, @loc, @type,
                      @status, @coverage, @date)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name",
                                                source.SourceName)
                    cmd.Parameters.AddWithValue("@loc",
                                                source.Location)
                    cmd.Parameters.AddWithValue("@type",
                                                source.SourceType)
                    cmd.Parameters.AddWithValue("@status",
                                                source.Status)
                    cmd.Parameters.AddWithValue("@coverage",
                                                source.CoverageHH)
                    cmd.Parameters.AddWithValue("@date",
                                                source.LastInspected)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error saving water source: " & ex.Message,
                            "Save Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' ── UpdateWaterSource ─────────────────────────────────
    ' Updates an existing water source record by SourceID.
    Public Shared Function UpdateWaterSource(
                           source As WaterSource) As Boolean
        Try
            Using conn As SqlConnection = ConnectionClass.GetConnection()
                conn.Open()
                Dim query As String =
                    "UPDATE WaterSources SET
                     SourceName    = @name,
                     Location      = @loc,
                     SourceType    = @type,
                     Status        = @status,
                     CoverageHH    = @coverage,
                     LastInspected = @date
                     WHERE SourceID = @id"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name",
                                                source.SourceName)
                    cmd.Parameters.AddWithValue("@loc",
                                                source.Location)
                    cmd.Parameters.AddWithValue("@type",
                                                source.SourceType)
                    cmd.Parameters.AddWithValue("@status",
                                                source.Status)
                    cmd.Parameters.AddWithValue("@coverage",
                                                source.CoverageHH)
                    cmd.Parameters.AddWithValue("@date",
                                                source.LastInspected)
                    cmd.Parameters.AddWithValue("@id",
                                                source.SourceID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error updating water source: " & ex.Message,
                            "Update Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' ── DeleteWaterSource ─────────────────────────────────
    ' Deletes a water source by SourceID.
    ' Also deletes related MaintenanceLogs first (cascade).
    Public Shared Function DeleteWaterSource(
                           sourceID As Integer) As Boolean
        Try
            Using conn As SqlConnection = ConnectionClass.GetConnection()
                conn.Open()
                ' Delete related maintenance logs first
                Dim deleteLogs As String =
                    "DELETE FROM MaintenanceLogs
                     WHERE SourceID = @id"
                Using cmd As New SqlCommand(deleteLogs, conn)
                    cmd.Parameters.AddWithValue("@id", sourceID)
                    cmd.ExecuteNonQuery()
                End Using
                ' Then delete the water source
                Dim deleteSource As String =
                    "DELETE FROM WaterSources
                     WHERE SourceID = @id"
                Using cmd As New SqlCommand(deleteSource, conn)
                    cmd.Parameters.AddWithValue("@id", sourceID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error deleting water source: " & ex.Message,
                            "Delete Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' ── LoadMaintenanceLogs ───────────────────────────────
    ' Loads maintenance logs joined with WaterSources name.
    ' Accepts optional SourceID filter.
    Public Shared Function LoadMaintenanceLogs(
                           Optional sourceID As Integer = 0) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As SqlConnection = ConnectionClass.GetConnection()
                conn.Open()
                Dim query As String
                If sourceID = 0 Then
                    query =
                        "SELECT m.LogID, w.SourceName, m.SourceID,
                                m.MaintenanceDate, m.TechnicianName,
                                m.IssueDescription, m.ActionTaken, m.Cost
                         FROM MaintenanceLogs m
                         INNER JOIN WaterSources w
                         ON m.SourceID = w.SourceID
                         ORDER BY m.MaintenanceDate DESC"
                Else
                    query =
                        "SELECT m.LogID, w.SourceName, m.SourceID,
                                m.MaintenanceDate, m.TechnicianName,
                                m.IssueDescription, m.ActionTaken, m.Cost
                         FROM MaintenanceLogs m
                         INNER JOIN WaterSources w
                         ON m.SourceID = w.SourceID
                         WHERE m.SourceID = @sourceID
                         ORDER BY m.MaintenanceDate DESC"
                End If
                Using cmd As New SqlCommand(query, conn)
                    If sourceID <> 0 Then
                        cmd.Parameters.AddWithValue("@sourceID", sourceID)
                    End If
                    Using adapter As New SqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading maintenance logs: " & ex.Message,
                            "Load Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    ' ── InsertMaintenanceLog ──────────────────────────────
    ' Inserts a new maintenance log record.
    Public Shared Function InsertMaintenanceLog(
                           log As MaintenanceLog) As Boolean
        Try
            Using conn As SqlConnection = ConnectionClass.GetConnection()
                conn.Open()
                Dim query As String =
                    "INSERT INTO MaintenanceLogs
                     (SourceID, MaintenanceDate, TechnicianName,
                      IssueDescription, ActionTaken, Cost)
                     VALUES
                     (@sourceID, @date, @tech,
                      @issue, @action, @cost)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@sourceID",
                                                log.SourceID)
                    cmd.Parameters.AddWithValue("@date",
                                                log.MaintenanceDate)
                    cmd.Parameters.AddWithValue("@tech",
                                                log.TechnicianName)
                    cmd.Parameters.AddWithValue("@issue",
                                                log.IssueDescription)
                    cmd.Parameters.AddWithValue("@action",
                                                log.ActionTaken)
                    cmd.Parameters.AddWithValue("@cost",
                                                log.Cost)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error saving log: " & ex.Message,
                            "Save Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' ── UpdateMaintenanceLog ──────────────────────────────
    ' Updates an existing maintenance log by LogID.
    Public Shared Function UpdateMaintenanceLog(
                           log As MaintenanceLog) As Boolean
        Try
            Using conn As SqlConnection = ConnectionClass.GetConnection()
                conn.Open()
                Dim query As String =
                    "UPDATE MaintenanceLogs SET
                     SourceID         = @sourceID,
                     MaintenanceDate  = @date,
                     TechnicianName   = @tech,
                     IssueDescription = @issue,
                     ActionTaken      = @action,
                     Cost             = @cost
                     WHERE LogID = @id"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@sourceID",
                                                log.SourceID)
                    cmd.Parameters.AddWithValue("@date",
                                                log.MaintenanceDate)
                    cmd.Parameters.AddWithValue("@tech",
                                                log.TechnicianName)
                    cmd.Parameters.AddWithValue("@issue",
                                                log.IssueDescription)
                    cmd.Parameters.AddWithValue("@action",
                                                log.ActionTaken)
                    cmd.Parameters.AddWithValue("@cost",
                                                log.Cost)
                    cmd.Parameters.AddWithValue("@id",
                                                log.LogID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error updating log: " & ex.Message,
                            "Update Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' ── DeleteMaintenanceLog ──────────────────────────────
    ' Deletes a maintenance log by LogID.
    Public Shared Function DeleteMaintenanceLog(
                           logID As Integer) As Boolean
        Try
            Using conn As SqlConnection = ConnectionClass.GetConnection()
                conn.Open()
                Dim query As String =
                    "DELETE FROM MaintenanceLogs
                     WHERE LogID = @id"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", logID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error deleting log: " & ex.Message,
                            "Delete Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' ── GetDashboardSummary ───────────────────────────────
    ' Returns summary counts for the dashboard display.
    Public Shared Function GetDashboardSummary() As Dictionary(Of String, Integer)
        Dim summary As New Dictionary(Of String, Integer)
        Try
            Using conn As SqlConnection = ConnectionClass.GetConnection()
                conn.Open()
                Dim query As String =
                    "SELECT
                     COUNT(*) AS Total,
                     SUM(CASE WHEN Status = 'Active'
                         THEN 1 ELSE 0 END) AS Active,
                     SUM(CASE WHEN Status = 'Needs Repair'
                         THEN 1 ELSE 0 END) AS NeedsRepair,
                     SUM(CASE WHEN Status = 'Inactive'
                         THEN 1 ELSE 0 END) AS Inactive
                     FROM WaterSources"
                Using cmd As New SqlCommand(query, conn)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            summary("Total") =
                                Convert.ToInt32(reader("Total"))
                            summary("Active") =
                                Convert.ToInt32(reader("Active"))
                            summary("NeedsRepair") =
                                Convert.ToInt32(reader("NeedsRepair"))
                            summary("Inactive") =
                                Convert.ToInt32(reader("Inactive"))
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading summary: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
        Return summary
    End Function

    ' ── LoadSourcesForComboBox ────────────────────────────
    ' Loads water sources for ComboBox in Maintenance form.
    Public Shared Function LoadSourcesForComboBox() As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As SqlConnection = ConnectionClass.GetConnection()
                conn.Open()
                Dim query As String =
                    "SELECT SourceID, SourceName
                     FROM WaterSources
                     ORDER BY SourceName"
                Using cmd As New SqlCommand(query, conn)
                    Using adapter As New SqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading sources: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

End Class
