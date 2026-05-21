<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReports
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.lblReportType = New System.Windows.Forms.Label()
        Me.cboReportType = New System.Windows.Forms.ComboBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.dgvReport = New System.Windows.Forms.DataGridView()
        Me.lblSummary = New System.Windows.Forms.Label()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()

        ' ── pnlHeader ──
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(74, 20, 140)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Size = New System.Drawing.Size(900, 60)

        Me.lblTitle.Text = "📊 Reports — Water Source Summary"
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 14)
        Me.lblTitle.Size = New System.Drawing.Size(600, 34)

        ' ── grpOptions ──
        Me.grpOptions.Text = "Report Options"
        Me.grpOptions.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.grpOptions.Location = New System.Drawing.Point(12, 72)
        Me.grpOptions.Size = New System.Drawing.Size(870, 70)

        Me.lblReportType.Text = "Report Type:"
        Me.lblReportType.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblReportType.Location = New System.Drawing.Point(14, 28)
        Me.lblReportType.Size = New System.Drawing.Size(90, 20)

        Me.cboReportType.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.cboReportType.Location = New System.Drawing.Point(110, 26)
        Me.cboReportType.Size = New System.Drawing.Size(260, 26)
        Me.cboReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReportType.Name = "cboReportType"

        Me.btnGenerate.Text = "📊 Generate Report"
        Me.btnGenerate.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.btnGenerate.BackColor = System.Drawing.Color.FromArgb(74, 20, 140)
        Me.btnGenerate.ForeColor = System.Drawing.Color.White
        Me.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerate.FlatAppearance.BorderSize = 0
        Me.btnGenerate.Location = New System.Drawing.Point(390, 22)
        Me.btnGenerate.Size = New System.Drawing.Size(160, 34)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand

        Me.btnExport.Text = "💾 Export to CSV"
        Me.btnExport.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.btnExport.BackColor = System.Drawing.Color.FromArgb(27, 94, 32)
        Me.btnExport.ForeColor = System.Drawing.Color.White
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExport.FlatAppearance.BorderSize = 0
        Me.btnExport.Location = New System.Drawing.Point(560, 22)
        Me.btnExport.Size = New System.Drawing.Size(160, 34)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Cursor = System.Windows.Forms.Cursors.Hand

        Me.btnBack.Text = "⬅ Back"
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(69, 90, 100)
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.Location = New System.Drawing.Point(730, 22)
        Me.btnBack.Size = New System.Drawing.Size(120, 34)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand

        Me.grpOptions.Controls.Add(Me.lblReportType)
        Me.grpOptions.Controls.Add(Me.cboReportType)
        Me.grpOptions.Controls.Add(Me.btnGenerate)
        Me.grpOptions.Controls.Add(Me.btnExport)
        Me.grpOptions.Controls.Add(Me.btnBack)

        ' ── lblSummary ──
        Me.lblSummary.Text = "Select a report type and click Generate Report."
        Me.lblSummary.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Italic)
        Me.lblSummary.ForeColor = System.Drawing.Color.FromArgb(74, 20, 140)
        Me.lblSummary.Location = New System.Drawing.Point(12, 152)
        Me.lblSummary.Size = New System.Drawing.Size(870, 24)
        Me.lblSummary.Name = "lblSummary"

        ' ── dgvReport ──
        Me.dgvReport.Location = New System.Drawing.Point(12, 180)
        Me.dgvReport.Size = New System.Drawing.Size(870, 380)
        Me.dgvReport.Name = "dgvReport"
        Me.dgvReport.AllowUserToAddRows = False
        Me.dgvReport.ReadOnly = True
        Me.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReport.BackgroundColor = System.Drawing.Color.White
        Me.dgvReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvReport.RowHeadersVisible = False
        Me.dgvReport.Font = New System.Drawing.Font("Segoe UI", 9)

        ' ── Form Settings ──
        Me.ClientSize = New System.Drawing.Size(896, 576)
        Me.Text = "AquaTrace Reports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.BackColor = System.Drawing.Color.FromArgb(243, 229, 245)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False

        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.lblSummary)
        Me.Controls.Add(Me.dgvReport)

        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.grpOptions.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents grpOptions As System.Windows.Forms.GroupBox
    Friend WithEvents lblReportType As System.Windows.Forms.Label
    Friend WithEvents cboReportType As System.Windows.Forms.ComboBox
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents dgvReport As System.Windows.Forms.DataGridView
    Friend WithEvents lblSummary As System.Windows.Forms.Label

End Class
