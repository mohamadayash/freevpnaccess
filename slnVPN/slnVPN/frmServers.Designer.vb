<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gdvServers = New System.Windows.Forms.DataGridView()
        Me.clnLocation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnServer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnProtocol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clUserName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnPassword = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RowClick = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.gdvServers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gdvServers
        '
        Me.gdvServers.BackgroundColor = System.Drawing.Color.White
        Me.gdvServers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gdvServers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clnLocation, Me.clnServer, Me.clnProtocol, Me.clUserName, Me.clnPassword, Me.RowClick})
        Me.gdvServers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gdvServers.Location = New System.Drawing.Point(0, 0)
        Me.gdvServers.Name = "gdvServers"
        Me.gdvServers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gdvServers.RowHeadersVisible = False
        Me.gdvServers.Size = New System.Drawing.Size(668, 203)
        Me.gdvServers.TabIndex = 0
        '
        'clnLocation
        '
        Me.clnLocation.DataPropertyName = "Location"
        Me.clnLocation.HeaderText = "Location"
        Me.clnLocation.Name = "clnLocation"
        Me.clnLocation.ReadOnly = True
        Me.clnLocation.Width = 120
        '
        'clnServer
        '
        Me.clnServer.DataPropertyName = "Server"
        Me.clnServer.HeaderText = "Server"
        Me.clnServer.Name = "clnServer"
        Me.clnServer.ReadOnly = True
        Me.clnServer.Width = 120
        '
        'clnProtocol
        '
        Me.clnProtocol.DataPropertyName = "Protocol"
        Me.clnProtocol.HeaderText = "Protocol"
        Me.clnProtocol.Name = "clnProtocol"
        Me.clnProtocol.ReadOnly = True
        '
        'clUserName
        '
        Me.clUserName.DataPropertyName = "Username"
        Me.clUserName.HeaderText = "User Name"
        Me.clUserName.Name = "clUserName"
        Me.clUserName.ReadOnly = True
        Me.clUserName.Width = 120
        '
        'clnPassword
        '
        Me.clnPassword.DataPropertyName = "Password"
        Me.clnPassword.HeaderText = "Password"
        Me.clnPassword.Name = "clnPassword"
        Me.clnPassword.ReadOnly = True
        '
        'RowClick
        '
        Me.RowClick.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RowClick.HeaderText = ""
        Me.RowClick.Name = "RowClick"
        Me.RowClick.Text = "Connect"
        '
        'frmServers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 203)
        Me.Controls.Add(Me.gdvServers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmServers"
        Me.Text = "VPN Servers"
        CType(Me.gdvServers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gdvServers As System.Windows.Forms.DataGridView
    Friend WithEvents clnLocation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnServer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnProtocol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clUserName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnPassword As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RowClick As System.Windows.Forms.DataGridViewButtonColumn

End Class
