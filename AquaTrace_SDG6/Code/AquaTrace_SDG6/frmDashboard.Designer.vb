<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
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
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblAppName = New System.Windows.Forms.Label()
        Me.pnlStats = New System.Windows.Forms.Panel()
        Me.pnlTotal = New System.Windows.Forms.Panel()
        Me.lblTotalCount = New System.Windows.Forms.Label()
        Me.lblTotalTitle = New System.Windows.Forms.Label()
        Me.pnlActive = New System.Windows.Forms.Panel()
        Me.lblActiveCount = New System.Windows.Forms.Label()
        Me.lblActiveTitle = New System.Windows.Forms.Label()
        Me.pnlRepair = New System.Windows.Forms.Panel()
        Me.lblRepairCount = New System.Windows.Forms.Label()
        Me.lblRepairTitle = New System.Windows.Forms.Label()
        Me.pnlInactive = New System.Windows.Forms.Panel()
        Me.lblInactiveCount = New System.Windows.Forms.Label()
        Me.lblInactiveTitle = New System.Windows.Forms.Label()
        Me.pnlNav = New System.Windows.Forms.Panel()
        Me.btnSources = New System.Windows.Forms.Button()
        Me.btnMaintenance = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblFooter = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.pnlStats.SuspendLayout()
        Me.pnlTotal.SuspendLayout()
        Me.pnlActive.SuspendLayout()
        Me.pnlRepair.SuspendLayout()
        Me.pnlInactive.SuspendLayout()
        Me.pnlNav.SuspendLayout()
        Me.SuspendLayout()

        ' ── pnlHeader ──
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(13, 71, 161)
        Me.pnlHeader.Controls.Add(Me.lblWelcome)
        Me.pnlHeader.Controls.Add(Me.lblAppName)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Size = New System.Drawing.Size(860, 90)

        Me.lblAppName.Text = "💧 AquaTrace Dashboard"
        Me.lblAppName.Font = New System.Drawing.Font("Segoe UI", 18, System.Drawing.FontStyle.Bold)
        Me.lblAppName.ForeColor = System.Drawing.Color.White
        Me.lblAppName.Location = New System.Drawing.Point(24, 14)
        Me.lblAppName.Size = New System.Drawing.Size(500, 36)

        Me.lblWelcome.Text = "Welcome!"
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(187, 222, 251)
        Me.lblWelcome.Location = New System.Drawing.Point(24, 54)
        Me.lblWelcome.Size = New System.Drawing.Size(600, 24)
        Me.lblWelcome.Name = "lblWelcome"

        ' ── pnlStats ──
        Me.pnlStats.BackColor = System.Drawing.Color.FromArgb(227, 242, 253)
        Me.pnlStats.Controls.Add(Me.pnlTotal)
        Me.pnlStats.Controls.Add(Me.pnlActive)
        Me.pnlStats.Controls.Add(Me.pnlRepair)
        Me.pnlStats.Controls.Add(Me.pnlInactive)
        Me.pnlStats.Location = New System.Drawing.Point(20, 110)
        Me.pnlStats.Size = New System.Drawing.Size(820, 140)

        ' ── Stat Cards ──
        Dim cardW As Integer = 185
        Dim cardH As Integer = 110
        Dim cardY As Integer = 15

        ' Total Card
        Me.pnlTotal.BackColor = System.Drawing.Color.FromArgb(13, 71, 161)
        Me.pnlTotal.Controls.Add(Me.lblTotalCount)
        Me.pnlTotal.Controls.Add(Me.lblTotalTitle)
        Me.pnlTotal.Location = New System.Drawing.Point(10, cardY)
        Me.pnlTotal.Size = New System.Drawing.Size(cardW, cardH)

        Me.lblTotalCount.Text = "0"
        Me.lblTotalCount.Font = New System.Drawing.Font("Segoe UI", 36, System.Drawing.FontStyle.Bold)
        Me.lblTotalCount.ForeColor = System.Drawing.Color.White
        Me.lblTotalCount.Location = New System.Drawing.Point(0, 14)
        Me.lblTotalCount.Size = New System.Drawing.Size(cardW, 56)
        Me.lblTotalCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTotalCount.Name = "lblTotalCount"

        Me.lblTotalTitle.Text = "Total Sources"
        Me.lblTotalTitle.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblTotalTitle.ForeColor = System.Drawing.Color.FromArgb(187, 222, 251)
        Me.lblTotalTitle.Location = New System.Drawing.Point(0, 74)
        Me.lblTotalTitle.Size = New System.Drawing.Size(cardW, 24)
        Me.lblTotalTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' Active Card
        Me.pnlActive.BackColor = System.Drawing.Color.FromArgb(27, 94, 32)
        Me.pnlActive.Controls.Add(Me.lblActiveCount)
        Me.pnlActive.Controls.Add(Me.lblActiveTitle)
        Me.pnlActive.Location = New System.Drawing.Point(215, cardY)
        Me.pnlActive.Size = New System.Drawing.Size(cardW, cardH)

        Me.lblActiveCount.Text = "0"
        Me.lblActiveCount.Font = New System.Drawing.Font("Segoe UI", 36, System.Drawing.FontStyle.Bold)
        Me.lblActiveCount.ForeColor = System.Drawing.Color.White
        Me.lblActiveCount.Location = New System.Drawing.Point(0, 14)
        Me.lblActiveCount.Size = New System.Drawing.Size(cardW, 56)
        Me.lblActiveCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblActiveCount.Name = "lblActiveCount"

        Me.lblActiveTitle.Text = "Active"
        Me.lblActiveTitle.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblActiveTitle.ForeColor = System.Drawing.Color.FromArgb(200, 230, 201)
        Me.lblActiveTitle.Location = New System.Drawing.Point(0, 74)
        Me.lblActiveTitle.Size = New System.Drawing.Size(cardW, 24)
        Me.lblActiveTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' Needs Repair Card
        Me.pnlRepair.BackColor = System.Drawing.Color.FromArgb(230, 81, 0)
        Me.pnlRepair.Controls.Add(Me.lblRepairCount)
        Me.pnlRepair.Controls.Add(Me.lblRepairTitle)
        Me.pnlRepair.Location = New System.Drawing.Point(420, cardY)
        Me.pnlRepair.Size = New System.Drawing.Size(cardW, cardH)

        Me.lblRepairCount.Text = "0"
        Me.lblRepairCount.Font = New System.Drawing.Font("Segoe UI", 36, System.Drawing.FontStyle.Bold)
        Me.lblRepairCount.ForeColor = System.Drawing.Color.White
        Me.lblRepairCount.Location = New System.Drawing.Point(0, 14)
        Me.lblRepairCount.Size = New System.Drawing.Size(cardW, 56)
        Me.lblRepairCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblRepairCount.Name = "lblRepairCount"

        Me.lblRepairTitle.Text = "Needs Repair"
        Me.lblRepairTitle.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblRepairTitle.ForeColor = System.Drawing.Color.FromArgb(255, 224, 178)
        Me.lblRepairTitle.Location = New System.Drawing.Point(0, 74)
        Me.lblRepairTitle.Size = New System.Drawing.Size(cardW, 24)
        Me.lblRepairTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' Inactive Card
        Me.pnlInactive.BackColor = System.Drawing.Color.FromArgb(97, 97, 97)
        Me.pnlInactive.Controls.Add(Me.lblInactiveCount)
        Me.pnlInactive.Controls.Add(Me.lblInactiveTitle)
        Me.pnlInactive.Location = New System.Drawing.Point(625, cardY)
        Me.pnlInactive.Size = New System.Drawing.Size(cardW, cardH)

        Me.lblInactiveCount.Text = "0"
        Me.lblInactiveCount.Font = New System.Drawing.Font("Segoe UI", 36, System.Drawing.FontStyle.Bold)
        Me.lblInactiveCount.ForeColor = System.Drawing.Color.White
        Me.lblInactiveCount.Location = New System.Drawing.Point(0, 14)
        Me.lblInactiveCount.Size = New System.Drawing.Size(cardW, 56)
        Me.lblInactiveCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblInactiveCount.Name = "lblInactiveCount"

        Me.lblInactiveTitle.Text = "Inactive"
        Me.lblInactiveTitle.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblInactiveTitle.ForeColor = System.Drawing.Color.FromArgb(238, 238, 238)
        Me.lblInactiveTitle.Location = New System.Drawing.Point(0, 74)
        Me.lblInactiveTitle.Size = New System.Drawing.Size(cardW, 24)
        Me.lblInactiveTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' ── pnlNav ──
        Me.pnlNav.BackColor = System.Drawing.Color.White
        Me.pnlNav.Controls.Add(Me.btnSources)
        Me.pnlNav.Controls.Add(Me.btnMaintenance)
        Me.pnlNav.Controls.Add(Me.btnReports)
        Me.pnlNav.Controls.Add(Me.btnLogout)
        Me.pnlNav.Location = New System.Drawing.Point(20, 270)
        Me.pnlNav.Size = New System.Drawing.Size(820, 200)

        ' Navigation Buttons
        Me.btnSources.Text = "💧 Water Sources" & Environment.NewLine & "Manage water access points"
        Me.btnSources.Font = New System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Bold)
        Me.btnSources.BackColor = System.Drawing.Color.FromArgb(13, 71, 161)
        Me.btnSources.ForeColor = System.Drawing.Color.White
        Me.btnSources.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSources.FlatAppearance.BorderSize = 0
        Me.btnSources.Location = New System.Drawing.Point(20, 20)
        Me.btnSources.Size = New System.Drawing.Size(370, 70)
        Me.btnSources.Name = "btnSources"
        Me.btnSources.Cursor = System.Windows.Forms.Cursors.Hand

        Me.btnMaintenance.Text = "🔧 Maintenance Logs" & Environment.NewLine & "Track maintenance activities"
        Me.btnMaintenance.Font = New System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Bold)
        Me.btnMaintenance.BackColor = System.Drawing.Color.FromArgb(27, 94, 32)
        Me.btnMaintenance.ForeColor = System.Drawing.Color.White
        Me.btnMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaintenance.FlatAppearance.BorderSize = 0
        Me.btnMaintenance.Location = New System.Drawing.Point(430, 20)
        Me.btnMaintenance.Size = New System.Drawing.Size(370, 70)
        Me.btnMaintenance.Name = "btnMaintenance"
        Me.btnMaintenance.Cursor = System.Windows.Forms.Cursors.Hand

        Me.btnReports.Text = "📊 Reports" & Environment.NewLine & "Generate summary reports"
        Me.btnReports.Font = New System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Bold)
        Me.btnReports.BackColor = System.Drawing.Color.FromArgb(74, 20, 140)
        Me.btnReports.ForeColor = System.Drawing.Color.White
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReports.FlatAppearance.BorderSize = 0
        Me.btnReports.Location = New System.Drawing.Point(20, 110)
        Me.btnReports.Size = New System.Drawing.Size(370, 70)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Cursor = System.Windows.Forms.Cursors.Hand

        Me.btnLogout.Text = "🚪 Logout"
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Bold)
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(183, 28, 28)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.Location = New System.Drawing.Point(430, 110)
        Me.btnLogout.Size = New System.Drawing.Size(370, 70)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand

        ' ── lblFooter ──
        Me.lblFooter.Text = "AquaTrace v1.0  |  SDG 6 — Clean Water & Sanitation"
        Me.lblFooter.Font = New System.Drawing.Font("Segoe UI", 8)
        Me.lblFooter.ForeColor = System.Drawing.Color.FromArgb(117, 117, 117)
        Me.lblFooter.Location = New System.Drawing.Point(0, 490)
        Me.lblFooter.Size = New System.Drawing.Size(860, 20)
        Me.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' ── Form Settings ──
        Me.ClientSize = New System.Drawing.Size(860, 520)
        Me.Text = "AquaTrace Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.BackColor = System.Drawing.Color.FromArgb(227, 242, 253)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False

        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlStats)
        Me.Controls.Add(Me.pnlNav)
        Me.Controls.Add(Me.lblFooter)

        Me.pnlHeader.ResumeLayout(False)
        Me.pnlStats.ResumeLayout(False)
        Me.pnlTotal.ResumeLayout(False)
        Me.pnlActive.ResumeLayout(False)
        Me.pnlRepair.ResumeLayout(False)
        Me.pnlInactive.ResumeLayout(False)
        Me.pnlNav.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblAppName As System.Windows.Forms.Label
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents pnlStats As System.Windows.Forms.Panel
    Friend WithEvents pnlTotal As System.Windows.Forms.Panel
    Friend WithEvents lblTotalCount As System.Windows.Forms.Label
    Friend WithEvents lblTotalTitle As System.Windows.Forms.Label
    Friend WithEvents pnlActive As System.Windows.Forms.Panel
    Friend WithEvents lblActiveCount As System.Windows.Forms.Label
    Friend WithEvents lblActiveTitle As System.Windows.Forms.Label
    Friend WithEvents pnlRepair As System.Windows.Forms.Panel
    Friend WithEvents lblRepairCount As System.Windows.Forms.Label
    Friend WithEvents lblRepairTitle As System.Windows.Forms.Label
    Friend WithEvents pnlInactive As System.Windows.Forms.Panel
    Friend WithEvents lblInactiveCount As System.Windows.Forms.Label
    Friend WithEvents lblInactiveTitle As System.Windows.Forms.Label
    Friend WithEvents pnlNav As System.Windows.Forms.Panel
    Friend WithEvents btnSources As System.Windows.Forms.Button
    Friend WithEvents btnMaintenance As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents lblFooter As System.Windows.Forms.Label

End Class
