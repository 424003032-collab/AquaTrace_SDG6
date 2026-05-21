Imports System.IO
Imports System.Data

Public Class frmReports

    ' ── FORM LOAD ─────────────────────────────────────────
    Private Sub frmReports_Load(sender As Object,
                                 e As EventArgs) Handles MyBase.Load
        cboReportType.Items.AddRange({
            "All Water Sources",
            "Active Water Sources",
            "Sources Needing Repair",
            "Inactive Water Sources",
            "All Maintenance Logs",
            "High Cost Maintenance (₱5000+)"
        })
        cboReportType.SelectedIndex = 0
    End Sub

    ' ── GENERATE REPORT ───────────────────────────────────
    Private Sub btnGenerate_Click(sender As Object,
                                   e As EventArgs) Handles btnGenerate.Click
        Try
            Dim reportType As String =
                cboReportType.SelectedItem.ToString()
            Dim dt As DataTable

            Select Case reportType
                Case "All Water Sources"
                    dt = DBManager.LoadWaterSources()
                    lblSummary.Text =
                        "Total Records: " & dt.Rows.Count &
                        " | All community water access points"

                Case "Active Water Sources"
                    dt = DBManager.LoadWaterSources("Active")
                    lblSummary.Text =
                        "Active Sources: " & dt.Rows.Count &
                        " | Fully operational water points"

                Case "Sources Needing Repair"
                    dt = DBManager.LoadWaterSources("Needs Repair")
                    lblSummary.Text =
                        "Needs Repair: " & dt.Rows.Count &
                        " | Requires immediate maintenance"

                Case "Inactive Water Sources"
                    dt = DBManager.LoadWaterSources("Inactive")
                    lblSummary.Text =
                        "Inactive: " & dt.Rows.Count &
                        " | Non-operational water points"

                Case "All Maintenance Logs"
                    dt = DBManager.LoadMaintenanceLogs()
                    lblSummary.Text =
                        "Total Logs: " & dt.Rows.Count &
                        " | All maintenance activities recorded"

                Case "High Cost Maintenance (₱5000+)"
                    dt = DBManager.LoadMaintenanceLogs()
                    ' Filter high cost in memory
                    Dim filtered As DataTable = dt.Clone()
                    For Each row As DataRow In dt.Rows
                        If Convert.ToDecimal(row("Cost")) >= 5000 Then
                            filtered.ImportRow(row)
                        End If
                    Next
                    dt = filtered
                    lblSummary.Text =
                        "High Cost Logs: " & dt.Rows.Count &
                        " | Maintenance activities costing ₱5,000+"

                Case Else
                    dt = DBManager.LoadWaterSources()
            End Select

            dgvReport.DataSource = dt
            dgvReport.AutoResizeColumns()

            If dt.Rows.Count = 0 Then
                lblSummary.Text = "No records found for this report."
            End If

        Catch ex As Exception
            MessageBox.Show("Error generating report: " & ex.Message,
                            "Report Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    ' ── EXPORT TO CSV ─────────────────────────────────────
    Private Sub btnExport_Click(sender As Object,
                                 e As EventArgs) Handles btnExport.Click
        If dgvReport.Rows.Count = 0 Then
            MessageBox.Show("Please generate a report first.",
                            "No Data",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "CSV Files (*.csv)|*.csv"
            saveDialog.FileName = "AquaTrace_Report_" &
                                   DateTime.Now.ToString("yyyyMMdd_HHmmss")

            If saveDialog.ShowDialog() = DialogResult.OK Then
                Using writer As New StreamWriter(saveDialog.FileName)
                    ' Write headers
                    Dim headers As New List(Of String)
                    For Each col As DataGridViewColumn In dgvReport.Columns
                        headers.Add(col.HeaderText)
                    Next
                    writer.WriteLine(String.Join(",", headers))

                    ' Write rows
                    For Each row As DataGridViewRow In dgvReport.Rows
                        Dim values As New List(Of String)
                        For Each cell As DataGridViewCell In row.Cells
                            values.Add(If(cell.Value IsNot Nothing,
                                          cell.Value.ToString(), ""))
                        Next
                        writer.WriteLine(String.Join(",", values))
                    Next
                End Using

                MessageBox.Show("Report exported successfully!" &
                                Environment.NewLine &
                                saveDialog.FileName,
                                "Export Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error exporting: " & ex.Message,
                            "Export Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    ' ── BACK BUTTON ───────────────────────────────────────
    Private Sub btnBack_Click(sender As Object,
                               e As EventArgs) Handles btnBack.Click
        Dim dashboard As New frmDashboard()
        dashboard.Show()
        Me.Close()
    End Sub

    ' ── FORM CLOSING ──────────────────────────────────────
    Private Sub frmReports_FormClosing(sender As Object,
                                        e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dashboard As New frmDashboard()
        dashboard.Show()
    End Sub

End Class
