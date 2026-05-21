<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMaintenance
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
        Me.grpInput = New System.Windows.Forms.GroupBox()
        Me.lblSource = New System.Windows.Forms.Label()
        Me.cboSource = New System.Windows.Forms.ComboBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.lblTechnician = New System.Windows.Forms.Label()
        Me.txtTechnician = New System.Windows.Forms.TextBox()
        Me.lblIssue = New System.Windows.Forms.Label()
        Me.txtIssue = New System.Windows.Forms.TextBox()
        Me.lblAction = New System.Windows.Forms.Label()
        Me.txtAction = New System.Windows.Forms.TextBox()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.grpActions = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.dgvLogs = New System.Windows.Forms.DataGridView()
        CType(Me.dgvLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.grpInput.SuspendLayout()
        Me.grpActions.SuspendLayout()
        Me.SuspendLayout()

        ' ── pnlHeader ──
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(27, 94, 32)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Size = New System.Drawing.Size(1000, 60)

        Me.lblTitle.Text = "🔧 Maintenance Log Management"
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 14)
        Me.lblTitle.Size = New System.Drawing.Size(600, 34)

        ' ── grpInput ──
        Me.grpInput.Text = "Maintenance Log Information"
        Me.grpInput.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.grpInput.Location = New System.Drawing.Point(12, 72)
        Me.grpInput.Size = New System.Drawing.Size(600, 250)

        Me.lblSource.Text = "Water Source:"
        Me.lblSource.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblSource.Location = New System.Drawing.Point(14, 28)
        Me.lblSource.Size = New System.Drawing.Size(100, 20)

        Me.cboSource.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.cboSource.Location = New System.Drawing.Point(120, 26)
        Me.cboSource.Size = New System.Drawing.Size(260, 26)
        Me.cboSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSource.Name = "cboSource"

        Me.lblDate.Text = "Date:"
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblDate.Location = New System.Drawing.Point(400, 28)
        Me.lblDate.Size = New System.Drawing.Size(60, 20)

        Me.dtpDate.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.dtpDate.Location = New System.Drawing.Point(460, 26)
        Me.dtpDate.Size = New System.Drawing.Size(120, 26)
        Me.dtpDate.Name = "dtpDate"

        Me.lblTechnician.Text = "Technician:"
        Me.lblTechnician.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblTechnician.Location = New System.Drawing.Point(14, 64)
        Me.lblTechnician.Size = New System.Drawing.Size(100, 20)

        Me.txtTechnician.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.txtTechnician.Location = New System.Drawing.Point(120, 62)
        Me.txtTechnician.Size = New System.Drawing.Size(460, 26)
        Me.txtTechnician.Name = "txtTechnician"

        Me.lblIssue.Text = "Issue Found:"
        Me.lblIssue.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblIssue.Location = New System.Drawing.Point(14, 100)
        Me.lblIssue.Size = New System.Drawing.Size(100, 20)

        Me.txtIssue.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.txtIssue.Location = New System.Drawing.Point(120, 98)
        Me.txtIssue.Size = New System.Drawing.Size(460, 26)
        Me.txtIssue.Name = "txtIssue"

        Me.lblAction.Text = "Action Taken:"
        Me.lblAction.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblAction.Location = New System.Drawing.Point(14, 136)
        Me.lblAction.Size = New System.Drawing.Size(100, 20)

        Me.txtAction.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.txtAction.Location = New System.Drawing.Point(120, 134)
        Me.txtAction.Size = New System.Drawing.Size(460, 26)
        Me.txtAction.Name = "txtAction"

        Me.lblCost.Text = "Cost (₱):"
        Me.lblCost.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblCost.Location = New System.Drawing.Point(14, 172)
        Me.lblCost.Size = New System.Drawing.Size(100, 20)

        Me.txtCost.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.txtCost.Location = New System.Drawing.Point(120, 170)
        Me.txtCost.Size = New System.Drawing.Size(200, 26)
        Me.txtCost.Name = "txtCost"

        Me.grpInput.Controls.Add(Me.lblSource)
        Me.grpInput.Controls.Add(Me.cboSource)
        Me.grpInput.Controls.Add(Me.lblDate)
        Me.grpInput.Controls.Add(Me.dtpDate)
        Me.grpInput.Controls.Add(Me.lblTechnician)
        Me.grpInput.Controls.Add(Me.txtTechnician)
        Me.grpInput.Controls.Add(Me.lblIssue)
        Me.grpInput.Controls.Add(Me.txtIssue)
        Me.grpInput.Controls.Add(Me.lblAction)
        Me.grpInput.Controls.Add(Me.txtAction)
        Me.grpInput.Controls.Add(Me.lblCost)
        Me.grpInput.Controls.Add(Me.txtCost)

        ' ── grpActions ──
        Me.grpActions.Text = "Actions"
        Me.grpActions.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.grpActions.Location = New System.Drawing.Point(622, 72)
        Me.grpActions.Size = New System.Drawing.Size(360, 250)

        Me.btnSave.Text = "💾 Save"
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(27, 94, 32)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.Location = New System.Drawing.Point(14, 28)
        Me.btnSave.Size = New System.Drawing.Size(155, 50)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand

        Me.btnUpdate.Text = "✏️ Update"
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(13, 71, 161)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.Location = New System.Drawing.Point(184, 28)
        Me.btnUpdate.Size = New System.Drawing.Size(155, 50)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand

        Me.btnDelete.Text = "🗑️ Delete"
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(183, 28, 28)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.Location = New System.Drawing.Point(14, 94)
        Me.btnDelete.Size = New System.Drawing.Size(155, 50)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand

        Me.btnClear.Text = "🔄 Clear"
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(230, 81, 0)
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.Location = New System.Drawing.Point(184, 94)
        Me.btnClear.Size = New System.Drawing.Size(155, 50)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand

        Me.btnBack.Text = "⬅ Back to Dashboard"
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(69, 90, 100)
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.Location = New System.Drawing.Point(14, 190)
        Me.btnBack.Size = New System.Drawing.Size(325, 50)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand

        Me.grpActions.Controls.Add(Me.btnSave)
        Me.grpActions.Controls.Add(Me.btnUpdate)
        Me.grpActions.Controls.Add(Me.btnDelete)
        Me.grpActions.Controls.Add(Me.btnClear)
        Me.grpActions.Controls.Add(Me.btnBack)

        ' ── dgvLogs ──
        Me.dgvLogs.Location = New System.Drawing.Point(12, 334)
        Me.dgvLogs.Size = New System.Drawing.Size(970, 300)
        Me.dgvLogs.Name = "dgvLogs"
        Me.dgvLogs.AllowUserToAddRows = False
        Me.dgvLogs.ReadOnly = True
        Me.dgvLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLogs.BackgroundColor = System.Drawing.Color.White
        Me.dgvLogs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvLogs.RowHeadersVisible = False
        Me.dgvLogs.Font = New System.Drawing.Font("Segoe UI", 9)

        ' ── Form Settings ──
        Me.ClientSize = New System.Drawing.Size(996, 648)
        Me.Text = "AquaTrace Maintenance Log Management"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.BackColor = System.Drawing.Color.FromArgb(232, 245, 233)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False

        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.grpInput)
        Me.Controls.Add(Me.grpActions)
        Me.Controls.Add(Me.dgvLogs)

        CType(Me.dgvLogs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.grpInput.ResumeLayout(False)
        Me.grpInput.PerformLayout()
        Me.grpActions.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents grpInput As System.Windows.Forms.GroupBox
    Friend WithEvents lblSource As System.Windows.Forms.Label
    Friend WithEvents cboSource As System.Windows.Forms.ComboBox
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTechnician As System.Windows.Forms.Label
    Friend WithEvents txtTechnician As System.Windows.Forms.TextBox
    Friend WithEvents lblIssue As System.Windows.Forms.Label
    Friend WithEvents txtIssue As System.Windows.Forms.TextBox
    Friend WithEvents lblAction As System.Windows.Forms.Label
    Friend WithEvents txtAction As System.Windows.Forms.TextBox
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents grpActions As System.Windows.Forms.GroupBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents dgvLogs As System.Windows.Forms.DataGridView

End Class
