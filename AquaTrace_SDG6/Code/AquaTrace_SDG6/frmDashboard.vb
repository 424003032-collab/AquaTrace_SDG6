Public Class frmDashboard

    ' ── FORM LOAD ─────────────────────────────────────────
    Private Sub frmDashboard_Load(sender As Object,
                                   e As EventArgs) Handles MyBase.Load
        ' Display welcome message with logged in user info
        lblWelcome.Text = frmLogin.LoggedInUser.GetWelcomeMessage()

        ' Restrict Reports button for Standard Users
        If Not frmLogin.LoggedInUser.IsAdmin() Then
            btnReports.Enabled = False
            btnReports.Text = "📊 Reports" &
                              Environment.NewLine &
                              "(Admin only)"
        End If

        ' Load dashboard summary stats
        LoadSummary()
    End Sub

    ' ── LOAD SUMMARY ──────────────────────────────────────
    Private Sub LoadSummary()
        Dim summary = DBManager.GetDashboardSummary()
        If summary.Count > 0 Then
            lblTotalCount.Text = summary("Total").ToString()
            lblActiveCount.Text = summary("Active").ToString()
            lblRepairCount.Text = summary("NeedsRepair").ToString()
            lblInactiveCount.Text = summary("Inactive").ToString()
        End If
    End Sub

    ' ── WATER SOURCES BUTTON ──────────────────────────────
    Private Sub btnSources_Click(sender As Object,
                                  e As EventArgs) Handles btnSources.Click
        Dim frm As New frmSources()
        frm.Show()
        Me.Hide()
    End Sub

    ' ── MAINTENANCE BUTTON ────────────────────────────────
    Private Sub btnMaintenance_Click(sender As Object,
                                      e As EventArgs) Handles btnMaintenance.Click
        Dim frm As New frmMaintenance()
        frm.Show()
        Me.Hide()
    End Sub

    ' ── REPORTS BUTTON ────────────────────────────────────
    Private Sub btnReports_Click(sender As Object,
                                  e As EventArgs) Handles btnReports.Click
        Dim frm As New frmReports()
        frm.Show()
        Me.Hide()
    End Sub

    ' ── LOGOUT BUTTON ─────────────────────────────────────
    Private Sub btnLogout_Click(sender As Object,
                                 e As EventArgs) Handles btnLogout.Click
        Dim confirm As DialogResult = MessageBox.Show(
            "Are you sure you want to logout?",
            "Confirm Logout",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If confirm = DialogResult.Yes Then
            frmLogin.LoggedInUser = Nothing
            Dim login As New frmLogin()
            login.Show()
            Me.Close()
        End If
    End Sub

    ' ── FORM CLOSING ──────────────────────────────────────
    Private Sub frmDashboard_FormClosing(sender As Object,
                                          e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

End Class
