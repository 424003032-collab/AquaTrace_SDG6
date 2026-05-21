<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSources
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
        Me.lblSourceName = New System.Windows.Forms.Label()
        Me.txtSourceName = New System.Windows.Forms.TextBox()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.lblSourceType = New System.Windows.Forms.Label()
        Me.cboSourceType = New System.Windows.Forms.ComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.lblCoverage = New System.Windows.Forms.Label()
        Me.txtCoverage = New System.Windows.Forms.TextBox()
        Me.lblInspected = New System.Windows.Forms.Label()
        Me.dtpInspected = New System.Windows.Forms.DateTimePicker()
        Me.grpSearch = New System.Windows.Forms.GroupBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnClearSearch = New System.Windows.Forms.Button()
        Me.grpActions = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.dgvSources = New System.Windows.Forms.DataGridView()
        CType(Me.dgvSources, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.grpInput.SuspendLayout()
        Me.grpSearch.SuspendLayout()
        Me.grpActions.SuspendLayout()
        Me.SuspendLayout()

        ' ── pnlHeader ──
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(13, 71, 161)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Size = New System.Drawing.Size(1000, 60)

        Me.lblTitle.Text = "💧 Water Source Management"
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 14)
        Me.lblTitle.Size = New System.Drawing.Size(600, 34)

        ' ── grpInput ──
        Me.grpInput.Text = "Water Source Information"
        Me.grpInput.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.grpInput.Location = New System.Drawing.Point(12, 72)
        Me.grpInput.Size = New System.Drawing.Size(600, 220)

        ' Row 1
        Me.lblSourceName.Text = "Source Name:"
        Me.lblSourceName.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblSourceName.Location = New System.Drawing.Point(14, 28)
        Me.lblSourceName.Size = New System.Drawing.Size(100, 20)

        Me.txtSourceName.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.txtSourceName.Location = New System.Drawing.Point(120, 26)
        Me.txtSourceName.Size = New System.Drawing.Size(460, 26)
        Me.txtSourceName.Name = "txtSourceName"

        ' Row 2
        Me.lblLocation.Text = "Location:"
        Me.lblLocation.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblLocation.Location = New System.Drawing.Point(14, 64)
        Me.lblLocation.Size = New System.Drawing.Size(100, 20)

        Me.txtLocation.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.txtLocation.Location = New System.Drawing.Point(120, 62)
        Me.txtLocation.Size = New System.Drawing.Size(460, 26)
        Me.txtLocation.Name = "txtLocation"

        ' Row 3
        Me.lblSourceType.Text = "Source Type:"
        Me.lblSourceType.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblSourceType.Location = New System.Drawing.Point(14, 100)
        Me.lblSourceType.Size = New System.Drawing.Size(100, 20)

        Me.cboSourceType.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.cboSourceType.Location = New System.Drawing.Point(120, 98)
        Me.cboSourceType.Size = New System.Drawing.Size(200, 26)
        Me.cboSourceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSourceType.Name = "cboSourceType"

        Me.lblStatus.Text = "Status:"
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblStatus.Location = New System.Drawing.Point(340, 100)
        Me.lblStatus.Size = New System.Drawing.Size(60, 20)

        Me.cboStatus.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.cboStatus.Location = New System.Drawing.Point(406, 98)
        Me.cboStatus.Size = New System.Drawing.Size(174, 26)
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.Name = "cboStatus"

        ' Row 4
        Me.lblCoverage.Text = "Coverage (HH):"
        Me.lblCoverage.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblCoverage.Location = New System.Drawing.Point(14, 136)
        Me.lblCoverage.Size = New System.Drawing.Size(100, 20)

        Me.txtCoverage.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.txtCoverage.Location = New System.Drawing.Point(120, 134)
        Me.txtCoverage.Size = New System.Drawing.Size(200, 26)
        Me.txtCoverage.Name = "txtCoverage"

        Me.lblInspected.Text = "Last Inspected:"
        Me.lblInspected.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblInspected.Location = New System.Drawing.Point(340, 136)
        Me.lblInspected.Size = New System.Drawing.Size(100, 20)

        Me.dtpInspected.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.dtpInspected.Location = New System.Drawing.Point(446, 134)
        Me.dtpInspected.Size = New System.Drawing.Size(134, 26)
        Me.dtpInspected.Name = "dtpInspected"

        ' Add controls to grpInput
        Me.grpInput.Controls.Add(Me.lblSourceName)
        Me.grpInput.Controls.Add(Me.txtSourceName)
        Me.grpInput.Controls.Add(Me.lblLocation)
        Me.grpInput.Controls.Add(Me.txtLocation)
        Me.grpInput.Controls.Add(Me.lblSourceType)
        Me.grpInput.Controls.Add(Me.cboSourceType)
        Me.grpInput.Controls.Add(Me.lblStatus)
        Me.grpInput.Controls.Add(Me.cboStatus)
        Me.grpInput.Controls.Add(Me.lblCoverage)
        Me.grpInput.Controls.Add(Me.txtCoverage)
        Me.grpInput.Controls.Add(Me.lblInspected)
        Me.grpInput.Controls.Add(Me.dtpInspected)

        ' ── grpSearch ──
        Me.grpSearch.Text = "Search"
        Me.grpSearch.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.grpSearch.Location = New System.Drawing.Point(12, 300)
        Me.grpSearch.Size = New System.Drawing.Size(600, 60)

        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.txtSearch.Location = New System.Drawing.Point(14, 24)
        Me.txtSearch.Size = New System.Drawing.Size(340, 26)
        Me.txtSearch.Name = "txtSearch"

        Me.btnSearch.Text = "Search"
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(13, 71, 161)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.Location = New System.Drawing.Point(364, 22)
        Me.btnSearch.Size = New System.Drawing.Size(100, 30)
        Me.btnSearch.Name = "btnSearch"

        Me.btnClearSearch.Text = "Clear"
        Me.btnClearSearch.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.btnClearSearch.BackColor = System.Drawing.Color.FromArgb(97, 97, 97)
        Me.btnClearSearch.ForeColor = System.Drawing.Color.White
        Me.btnClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearSearch.FlatAppearance.BorderSize = 0
        Me.btnClearSearch.Location = New System.Drawing.Point(474, 22)
        Me.btnClearSearch.Size = New System.Drawing.Size(100, 30)
        Me.btnClearSearch.Name = "btnClearSearch"

        Me.grpSearch.Controls.Add(Me.txtSearch)
        Me.grpSearch.Controls.Add(Me.btnSearch)
        Me.grpSearch.Controls.Add(Me.btnClearSearch)

        ' ── grpActions ──
        Me.grpActions.Text = "Actions"
        Me.grpActions.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.grpActions.Location = New System.Drawing.Point(622, 72)
        Me.grpActions.Size = New System.Drawing.Size(360, 290)

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
        Me.btnBack.Location = New System.Drawing.Point(14, 220)
        Me.btnBack.Size = New System.Drawing.Size(325, 50)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand

        Me.grpActions.Controls.Add(Me.btnSave)
        Me.grpActions.Controls.Add(Me.btnUpdate)
        Me.grpActions.Controls.Add(Me.btnDelete)
        Me.grpActions.Controls.Add(Me.btnClear)
        Me.grpActions.Controls.Add(Me.btnBack)

        ' ── dgvSources ──
        Me.dgvSources.Location = New System.Drawing.Point(12, 372)
        Me.dgvSources.Size = New System.Drawing.Size(970, 280)
        Me.dgvSources.Name = "dgvSources"
        Me.dgvSources.AllowUserToAddRows = False
        Me.dgvSources.ReadOnly = True
        Me.dgvSources.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSources.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSources.BackgroundColor = System.Drawing.Color.White
        Me.dgvSources.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvSources.RowHeadersVisible = False
        Me.dgvSources.Font = New System.Drawing.Font("Segoe UI", 9)

        ' ── Form Settings ──
        Me.ClientSize = New System.Drawing.Size(996, 666)
        Me.Text = "AquaTrace Water Source Management"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.BackColor = System.Drawing.Color.FromArgb(227, 242, 253)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False

        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.grpInput)
        Me.Controls.Add(Me.grpSearch)
        Me.Controls.Add(Me.grpActions)
        Me.Controls.Add(Me.dgvSources)

        CType(Me.dgvSources, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.grpInput.ResumeLayout(False)
        Me.grpInput.PerformLayout()
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        Me.grpActions.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents grpInput As System.Windows.Forms.GroupBox
    Friend WithEvents lblSourceName As System.Windows.Forms.Label
    Friend WithEvents txtSourceName As System.Windows.Forms.TextBox
    Friend WithEvents lblLocation As System.Windows.Forms.Label
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents lblSourceType As System.Windows.Forms.Label
    Friend WithEvents cboSourceType As System.Windows.Forms.ComboBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblCoverage As System.Windows.Forms.Label
    Friend WithEvents txtCoverage As System.Windows.Forms.TextBox
    Friend WithEvents lblInspected As System.Windows.Forms.Label
    Friend WithEvents dtpInspected As System.Windows.Forms.DateTimePicker
    Friend WithEvents grpSearch As System.Windows.Forms.GroupBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnClearSearch As System.Windows.Forms.Button
    Friend WithEvents grpActions As System.Windows.Forms.GroupBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents dgvSources As System.Windows.Forms.DataGridView

End Class
