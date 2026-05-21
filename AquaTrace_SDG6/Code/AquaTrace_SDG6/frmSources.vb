Public Class frmSources

    Private selectedSourceID As Integer = -1

    ' ── FORM LOAD ─────────────────────────────────────────
    Private Sub frmSources_Load(sender As Object,
                                 e As EventArgs) Handles MyBase.Load
        ' Populate ComboBoxes
        cboSourceType.Items.AddRange({"Well", "Pump",
                                      "Reservoir", "Pipeline"})
        cboSourceType.SelectedIndex = 0

        cboStatus.Items.AddRange({"Active",
                                  "Needs Repair", "Inactive"})
        cboStatus.SelectedIndex = 0

        ' Restrict Delete for Standard Users
        If Not frmLogin.LoggedInUser.IsAdmin() Then
            btnDelete.Enabled = False
            btnDelete.BackColor = System.Drawing.Color.Gray
        End If

        LoadGrid()
    End Sub

    ' ── LOAD GRID ─────────────────────────────────────────
    Private Sub LoadGrid(Optional search As String = "")
        dgvSources.DataSource = DBManager.LoadWaterSources(search)
        dgvSources.AutoResizeColumns()
        selectedSourceID = -1
    End Sub

    ' ── SAVE BUTTON ───────────────────────────────────────
    Private Sub btnSave_Click(sender As Object,
                               e As EventArgs) Handles btnSave.Click
        If Not ValidateInputs() Then Exit Sub

        Dim source As New WaterSource()
        source.SourceName = txtSourceName.Text.Trim()
        source.Location = txtLocation.Text.Trim()
        source.SourceType = cboSourceType.SelectedItem.ToString()
        source.Status = cboStatus.SelectedItem.ToString()
        source.CoverageHH = Convert.ToInt32(txtCoverage.Text.Trim())
        source.LastInspected = dtpInspected.Value

        If DBManager.InsertWaterSource(source) Then
            MessageBox.Show("Water source saved successfully!" &
                            Environment.NewLine &
                            "Coverage Level: " &
                            source.GetCoverageLevel(),
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
        If selectedSourceID = -1 Then
            MessageBox.Show("Please select a record to update.",
                            "No Selection",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not ValidateInputs() Then Exit Sub

        Dim source As New WaterSource()
        source.SourceID = selectedSourceID
        source.SourceName = txtSourceName.Text.Trim()
        source.Location = txtLocation.Text.Trim()
        source.SourceType = cboSourceType.SelectedItem.ToString()
        source.Status = cboStatus.SelectedItem.ToString()
        source.CoverageHH = Convert.ToInt32(txtCoverage.Text.Trim())
        source.LastInspected = dtpInspected.Value

        If DBManager.UpdateWaterSource(source) Then
            MessageBox.Show("Water source updated successfully!",
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
        If selectedSourceID = -1 Then
            MessageBox.Show("Please select a record to delete.",
                            "No Selection",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim confirm As DialogResult = MessageBox.Show(
            "Are you sure you want to delete this water source?" &
            Environment.NewLine &
            "All related maintenance logs will also be deleted!",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning)

        If confirm = DialogResult.Yes Then
            If DBManager.DeleteWaterSource(selectedSourceID) Then
                MessageBox.Show("Water source deleted successfully!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                LoadGrid()
                ClearFields()
            End If
        End If
    End Sub

    ' ── SEARCH BUTTON ─────────────────────────────────────
    Private Sub btnSearch_Click(sender As Object,
                                 e As EventArgs) Handles btnSearch.Click
        LoadGrid(txtSearch.Text.Trim())
    End Sub

    ' ── CLEAR SEARCH ──────────────────────────────────────
    Private Sub btnClearSearch_Click(sender As Object,
                                      e As EventArgs) Handles btnClearSearch.Click
        txtSearch.Clear()
        LoadGrid()
    End Sub

    ' ── CLEAR FIELDS ──────────────────────────────────────
    Private Sub btnClear_Click(sender As Object,
                                e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    ' ── CELL CLICK — Load row into fields ─────────────────
    Private Sub dgvSources_CellClick(sender As Object,
                                      e As DataGridViewCellEventArgs) Handles dgvSources.CellClick
        If e.RowIndex >= 0 Then
            Try
                Dim row As DataGridViewRow = dgvSources.Rows(e.RowIndex)
                selectedSourceID = Convert.ToInt32(row.Cells("SourceID").Value)
                txtSourceName.Text = row.Cells("SourceName").Value.ToString()
                txtLocation.Text = row.Cells("Location").Value.ToString()
                cboSourceType.Text = row.Cells("SourceType").Value.ToString()
                cboStatus.Text = row.Cells("Status").Value.ToString()
                txtCoverage.Text = row.Cells("CoverageHH").Value.ToString()
                dtpInspected.Value = Convert.ToDateTime(row.Cells("LastInspected").Value)
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
        If String.IsNullOrWhiteSpace(txtSourceName.Text) Then
            MessageBox.Show("Please enter a Source Name.",
                            "Validation Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            txtSourceName.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtLocation.Text) Then
            MessageBox.Show("Please enter a Location.",
                            "Validation Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            txtLocation.Focus()
            Return False
        End If

        Dim coverage As Integer
        If Not Integer.TryParse(txtCoverage.Text, coverage) OrElse
           coverage <= 0 Then
            MessageBox.Show("Please enter a valid Coverage " &
                            "(number of households).",
                            "Validation Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            txtCoverage.Focus()
            Return False
        End If

        Return True
    End Function

    ' ── CLEAR FIELDS HELPER ───────────────────────────────
    Private Sub ClearFields()
        txtSourceName.Clear()
        txtLocation.Clear()
        txtCoverage.Clear()
        cboSourceType.SelectedIndex = 0
        cboStatus.SelectedIndex = 0
        dtpInspected.Value = DateTime.Now
        selectedSourceID = -1
        txtSourceName.Focus()
    End Sub

    ' ── FORM CLOSING ──────────────────────────────────────
    Private Sub frmSources_FormClosing(sender As Object,
                                        e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dashboard As New frmDashboard()
        dashboard.Show()
    End Sub

End Class
