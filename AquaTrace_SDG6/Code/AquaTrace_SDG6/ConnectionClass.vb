Imports Microsoft.Data.SqlClient

Public Class ConnectionClass

    ' ── CONNECTION STRING ─────────────────────────────────
    Private Shared ReadOnly _connectionString As String =
        "Server=(localdb)\ProjectModels;Database=AquaTrace_DB;Integrated Security=True;Trust Server Certificate=True;"

    ' ── GetConnection ─────────────────────────────────────
    Public Shared Function GetConnection() As SqlConnection
        Return New SqlConnection(_connectionString)
    End Function

    ' ── TestConnection ────────────────────────────────────
    Public Shared Function TestConnection() As Boolean
        Try
            Using conn As SqlConnection = GetConnection()
                conn.Open()
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Database connection failed!" & Environment.NewLine &
                            "Error: " & ex.Message & Environment.NewLine & Environment.NewLine &
                            "Please check your connection string in ConnectionClass.vb",
                            "Connection Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return False
        End Try
    End Function

End Class

