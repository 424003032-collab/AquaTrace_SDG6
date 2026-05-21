<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.pnlForm = New System.Windows.Forms.Panel()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblFooter = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.pnlForm.SuspendLayout()
        Me.SuspendLayout()

        ' ── pnlHeader ──
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(13, 71, 161)
        Me.pnlHeader.Controls.Add(Me.lblSubtitle)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Size = New System.Drawing.Size(420, 110)

        ' ── lblTitle ──
        Me.lblTitle.Text = "💧 AquaTrace"
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 22, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 18)
        Me.lblTitle.Size = New System.Drawing.Size(420, 45)
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' ── lblSubtitle ──
        Me.lblSubtitle.Text = "Community Water Access and Monitoring System"
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(187, 222, 251)
        Me.lblSubtitle.Location = New System.Drawing.Point(0, 66)
        Me.lblSubtitle.Size = New System.Drawing.Size(420, 30)
        Me.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' ── pnlForm ──
        Me.pnlForm.BackColor = System.Drawing.Color.White
        Me.pnlForm.Controls.Add(Me.lblUsername)
        Me.pnlForm.Controls.Add(Me.txtUsername)
        Me.pnlForm.Controls.Add(Me.lblPassword)
        Me.pnlForm.Controls.Add(Me.txtPassword)
        Me.pnlForm.Controls.Add(Me.btnLogin)
        Me.pnlForm.Controls.Add(Me.lblStatus)
        Me.pnlForm.Location = New System.Drawing.Point(30, 130)
        Me.pnlForm.Size = New System.Drawing.Size(360, 260)

        ' ── lblUsername ──
        Me.lblUsername.Text = "Username"
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33)
        Me.lblUsername.Location = New System.Drawing.Point(20, 24)
        Me.lblUsername.Size = New System.Drawing.Size(320, 20)

        ' ── txtUsername ──
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 11)
        Me.txtUsername.Location = New System.Drawing.Point(20, 48)
        Me.txtUsername.Size = New System.Drawing.Size(320, 32)
        Me.txtUsername.Name = "txtUsername"

        ' ── lblPassword ──
        Me.lblPassword.Text = "Password"
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33)
        Me.lblPassword.Location = New System.Drawing.Point(20, 96)
        Me.lblPassword.Size = New System.Drawing.Size(320, 20)

        ' ── txtPassword ──
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 11)
        Me.txtPassword.Location = New System.Drawing.Point(20, 120)
        Me.txtPassword.Size = New System.Drawing.Size(320, 32)
        Me.txtPassword.PasswordChar = "●"
        Me.txtPassword.Name = "txtPassword"

        ' ── btnLogin ──
        Me.btnLogin.Text = "Login"
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Bold)
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(13, 71, 161)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.Location = New System.Drawing.Point(20, 172)
        Me.btnLogin.Size = New System.Drawing.Size(320, 44)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand

        ' ── lblStatus ──
        Me.lblStatus.Text = ""
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblStatus.ForeColor = System.Drawing.Color.Red
        Me.lblStatus.Location = New System.Drawing.Point(20, 224)
        Me.lblStatus.Size = New System.Drawing.Size(320, 20)
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblStatus.Name = "lblStatus"

        ' ── lblFooter ──
        Me.lblFooter.Text = "SDG 6 — Clean Water & Sanitation"
        Me.lblFooter.Font = New System.Drawing.Font("Segoe UI", 8)
        Me.lblFooter.ForeColor = System.Drawing.Color.FromArgb(117, 117, 117)
        Me.lblFooter.Location = New System.Drawing.Point(0, 410)
        Me.lblFooter.Size = New System.Drawing.Size(420, 20)
        Me.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' ── Form Settings ──
        Me.ClientSize = New System.Drawing.Size(420, 440)
        Me.Text = "AquaTrace Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.BackColor = System.Drawing.Color.FromArgb(227, 242, 253)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False

        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlForm)
        Me.Controls.Add(Me.lblFooter)

        Me.pnlHeader.ResumeLayout(False)
        Me.pnlForm.ResumeLayout(False)
        Me.pnlForm.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents pnlForm As System.Windows.Forms.Panel
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblFooter As System.Windows.Forms.Label

End Class
