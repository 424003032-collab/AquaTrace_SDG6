Public Class frmLogin

    ' Stores the logged-in user globally for other forms to use
    Public Shared LoggedInUser As User

    ' ── FORM LOAD ─────────────────────────────────────────
    Private Sub frmLogin_Load(sender As Object,
                               e As EventArgs) Handles MyBase.Load
        ' Test database connection on startup
        If Not ConnectionClass.TestConnection() Then
            lblStatus.Text = "Cannot connect to database!"
            btnLogin.Enabled = False
        End If
    End Sub

    ' ── LOGIN BUTTON ──────────────────────────────────────
    Private Sub btnLogin_Click(sender As Object,
                                e As EventArgs) Handles btnLogin.Click
        ' VALIDATION: Check if fields are empty
        If String.IsNullOrWhiteSpace(txtUsername.Text) Then
            lblStatus.Text = "Please enter your username."
            txtUsername.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            lblStatus.Text = "Please enter your password."
            txtPassword.Focus()
            Exit Sub
        End If

        ' Attempt login via DBManager
        Dim user As User = DBManager.LoginUser(
            txtUsername.Text.Trim(),
            txtPassword.Text.Trim())

        If user IsNot Nothing Then
            ' Login successful — store logged in user
            LoggedInUser = user

            ' Open Dashboard and close Login
            Dim dashboard As New frmDashboard()
            dashboard.Show()
            Me.Hide()
        Else
            ' Login failed
            lblStatus.Text = "Invalid username or password."
            txtPassword.Clear()
            txtPassword.Focus()
        End If
    End Sub

    ' ── ENTER KEY SUPPORT ─────────────────────────────────
    ' Allow pressing Enter to trigger login
    Private Sub txtPassword_KeyDown(sender As Object,
                                     e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin_Click(sender, e)
        End If
    End Sub

    ' ── FORM CLOSING ──────────────────────────────────────
    ' Exit app when login window is closed
    Private Sub frmLogin_FormClosing(sender As Object,
                                      e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

End Class
