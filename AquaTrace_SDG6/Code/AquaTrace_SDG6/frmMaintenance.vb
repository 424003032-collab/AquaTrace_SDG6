Public Class frmMaintenance

    Private selectedLogID As Integer = -1

    ' ── FORM LOAD ─────────────────────────────────────────
    Private Sub frmMaintenance_Load(sender As Object,
                                     e As EventArgs) Handles MyBase.Load
        LoadSourceComboBox()

        ' Restrict Delete for Standard Users
        If Not frmLogin.LoggedInUser.IsAdmin() Then
            btnDelete.Enabled = False
            btnDelete.BackColor = System.Drawing.Color.Gray
        End If

        LoadGrid()
    End Sub

    ' ── LOAD SOURCE COMBOBOX ──────────────────────────────
    Private Sub LoadSourceComboBox()
        Dim dt = DBManager.LoadSourcesForComboBox()
        cboSource.DataSource = dt
        cboSource.DisplayMember = "SourceName"
        cboSource.ValueMember = "SourceID"
    End Sub

    ' ── LOAD GRID ─────────────────────────────────────────
    Private Sub LoadGrid()
        dgvLogs.DataSource = DBManager.LoadMaintenanceLogs()
        dgvLogs.AutoResizeColumns()
        selectedLogID = -1
    End Sub

    ' ── SAVE BUTTON ───────────────────────────────────────
    Private Sub btnSave_Click(sender As Object,
                               e As EventArgs) Handles btnSave.Click
        If Not ValidateInputs() Then Exit Sub

        Dim log As New MaintenanceLog()
        log.SourceID = Convert.ToInt32(cboSource.SelectedValue)
        log.MaintenanceDate = dtpDate.Value
        log.TechnicianName = txtTechnician.Text.Trim()
        log.IssueDescription = txtIssue.Text.Trim()
        log.ActionTaken = txtAction.Text.Trim()
        log.Cost = Convert.ToDecimal(txtCost.Text.Trim())

        If DBManager.InsertMaintenanceLog(log) Then
            MessageBox.Show("Maintenance log saved!" &
                            Environment.NewLine &
                            "Cost Level: " &
                            log.GetCostLevel() &
                            Environment.NewLine &
                            "Total Cost: " &
                            log.GetFormattedCost(),
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            LoadGrid()
            ClearFields()
        End If
    End Sub

    ' ── UPDATE BUTTON ─────────────────────────────────────
    Private Sub btnUpdate_Click(sender As Object,
                                 e As EventArgs) Handles btnUpdate.Click
        If selectedLogID = -1 Then
            MessageBox.Show("Please select a record to update.",
                            "No Selection",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not ValidateInputs() Then Exit Sub

        Dim log As New MaintenanceLog()
        log.LogID = selectedLogID
        log.SourceID = Convert.ToInt32(cboSource.SelectedValue)
        log.MaintenanceDate = dtpDate.Value
        log.TechnicianName = txtTechnician.Text.Trim()
        log.IssueDescription = txtIssue.Text.Trim()
        log.ActionTaken = txtAction.Text.Trim()
        log.Cost = Convert.ToDecimal(txtCost.Text.Trim())

        If DBManager.UpdateMaintenanceLog(log) Then
            MessageBox.Show("Maintenance log updated successfully!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            LoadGrid()
            ClearFields()
        End If
    End Sub

    ' ── DELETE BUTTON ─────────────────────────────────────
    Private Sub btnDelete_Click(sender As Object,
                                 e As EventArgs) Handles btnDelete.Click
        If selectedLogID = -1 Then
            MessageBox.Show("Please select a record to delete.",
                            "No Selection",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim confirm As DialogResult = MessageBox.Show(
            "Are you sure you want to delete this log?",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning)

        If confirm = DialogResult.Yes Then
            If DBManager.DeleteMaintenanceLog(selectedLogID) Then
                MessageBox.Show("Log deleted successfully!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                LoadGrid()
                ClearFields()
            End If
        End If
    End Sub

    ' ── CLEAR BUTTON ──────────────────────────────────────
    Private Sub btnClear_Click(sender As Object,
                                e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    ' ── CELL CLICK ────────────────────────────────────────
    Private Sub dgvLogs_CellClick(sender As Object,
                                   e As DataGridViewCellEventArgs) Handles dgvLogs.CellClick
        If e.RowIndex >= 0 Then
            Try
                Dim row As DataGridViewRow = dgvLogs.Rows(e.RowIndex)
                selectedLogID = Convert.ToInt32(row.Cells("LogID").Value)
                cboSource.SelectedValue = row.Cells("SourceID").Value
                dtpDate.Value = Convert.ToDateTime(row.Cells("MaintenanceDate").Value)
                txtTechnician.Text = row.Cells("TechnicianName").Value.ToString()
                txtIssue.Text = row.Cells("IssueDescription").Value.ToString()
                txtAction.Text = row.Cells("ActionTaken").Value.ToString()
                txtCost.Text = row.Cells("Cost").Value.ToString()
            Catch ex As Exception
                MessageBox.Show("Error selecting row: " & ex.Message)
            End Try
        End If
    End Sub

    ' ── BACK BUTTON ───────────────────────────────────────
    Private Sub btnBack_Click(sender As Object,
                               e As EventArgs) Handles btnBack.Click
        Dim dashboard As New frmDashboard()
        dashboard.Show()
        Me.Close()
    End Sub

    ' ── VALIDATE INPUTS ───────────────────────────────────
    Private Function ValidateInputs() As Boolean
        If cboSource.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Water Source.",
                            "Validation Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtTechnician.Text) Then
            MessageBox.Show("Please enter a Technician Name.",
                            "Validation Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            txtTechnician.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtIssue.Text) Then
            MessageBox.Show("Please enter the Issue Description.",
                            "Validation Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            txtIssue.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtAction.Text) Then
            MessageBox.Show("Please enter the Action Taken.",
                            "Validation Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            txtAction.Focus()
            Return False
        End If

        Dim cost As Decimal
        If Not Decimal.TryParse(txtCost.Text, cost) OrElse cost < 0 Then
            MessageBox.Show("Please enter a valid Cost amount.",
                            "Validation Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            txtCost.Focus()
            Return False
        End If

        Return True
    End Function

    ' ── CLEAR FIELDS HELPER ───────────────────────────────
    Private Sub ClearFields()
        If cboSource.Items.Count > 0 Then
            cboSource.SelectedIndex = 0
        End If
        dtpDate.Value = DateTime.Now
        txtTechnician.Clear()
        txtIssue.Clear()
        txtAction.Clear()
        txtCost.Clear()
        selectedLogID = -1
        txtTechnician.Focus()
    End Sub

    ' ── FORM CLOSING ──────────────────────────────────────
    Private Sub frmMaintenance_FormClosing(sender As Object,
                                            e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dashboard As New frmDashboard()
        dashboard.Show()
    End Sub

End Class
