'
' Form converted from MSAccess database using AccessDotNetConverter on Tuesday, January 14, 2014
' https://code.google.com/p/msaccess-subversion-control
' 
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChooseDB
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TxtServer = New System.Windows.Forms.TextBox()
        Me.LblServer = New System.Windows.Forms.Label()
        Me.TxtDB = New System.Windows.Forms.TextBox()
        Me.LblDB = New System.Windows.Forms.Label()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.LblUserName = New System.Windows.Forms.Label()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.LblPass = New System.Windows.Forms.Label()
        Me.ChkIntSec = New System.Windows.Forms.CheckBox()
        Me.LblIntSev = New System.Windows.Forms.Label()
        Me.CmdOK = New System.Windows.Forms.Button()
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.ErrProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtServer
        '
        Me.TxtServer.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.TxtServer.Location = New System.Drawing.Point(136, 19)
        Me.TxtServer.Name = "TxtServer"
        Me.TxtServer.Size = New System.Drawing.Size(148, 20)
        Me.TxtServer.TabIndex = 0
        '
        'LblServer
        '
        Me.LblServer.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LblServer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblServer.Location = New System.Drawing.Point(16, 19)
        Me.LblServer.Name = "LblServer"
        Me.LblServer.Size = New System.Drawing.Size(108, 16)
        Me.LblServer.TabIndex = 1
        Me.LblServer.Text = "Server"
        Me.LblServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtDB
        '
        Me.TxtDB.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.TxtDB.Location = New System.Drawing.Point(136, 44)
        Me.TxtDB.Name = "TxtDB"
        Me.TxtDB.Size = New System.Drawing.Size(148, 20)
        Me.TxtDB.TabIndex = 1
        '
        'LblDB
        '
        Me.LblDB.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LblDB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblDB.Location = New System.Drawing.Point(16, 44)
        Me.LblDB.Name = "LblDB"
        Me.LblDB.Size = New System.Drawing.Size(108, 16)
        Me.LblDB.TabIndex = 2
        Me.LblDB.Text = "Database"
        Me.LblDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtUser
        '
        Me.TxtUser.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.TxtUser.Location = New System.Drawing.Point(136, 92)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(148, 20)
        Me.TxtUser.TabIndex = 3
        '
        'LblUserName
        '
        Me.LblUserName.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LblUserName.Location = New System.Drawing.Point(16, 92)
        Me.LblUserName.Name = "LblUserName"
        Me.LblUserName.Size = New System.Drawing.Size(108, 16)
        Me.LblUserName.TabIndex = 4
        Me.LblUserName.Text = "User Name"
        Me.LblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtPass
        '
        Me.TxtPass.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.TxtPass.Location = New System.Drawing.Point(136, 116)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.Size = New System.Drawing.Size(148, 20)
        Me.TxtPass.TabIndex = 4
        '
        'LblPass
        '
        Me.LblPass.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LblPass.Location = New System.Drawing.Point(16, 116)
        Me.LblPass.Name = "LblPass"
        Me.LblPass.Size = New System.Drawing.Size(108, 16)
        Me.LblPass.TabIndex = 5
        Me.LblPass.Text = "Password"
        Me.LblPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ChkIntSec
        '
        Me.ChkIntSec.Location = New System.Drawing.Point(136, 68)
        Me.ChkIntSec.Name = "ChkIntSec"
        Me.ChkIntSec.Size = New System.Drawing.Size(14, 14)
        Me.ChkIntSec.TabIndex = 2
        '
        'LblIntSev
        '
        Me.LblIntSev.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LblIntSev.Location = New System.Drawing.Point(16, 68)
        Me.LblIntSev.Name = "LblIntSev"
        Me.LblIntSev.Size = New System.Drawing.Size(108, 16)
        Me.LblIntSev.TabIndex = 6
        Me.LblIntSev.Text = "Windows Security"
        Me.LblIntSev.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmdOK
        '
        Me.CmdOK.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.CmdOK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdOK.Location = New System.Drawing.Point(196, 148)
        Me.CmdOK.Name = "CmdOK"
        Me.CmdOK.Size = New System.Drawing.Size(92, 24)
        Me.CmdOK.TabIndex = 6
        Me.CmdOK.Text = "&OK"
        '
        'CmdCancel
        '
        Me.CmdCancel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.CmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdCancel.Location = New System.Drawing.Point(92, 148)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(92, 24)
        Me.CmdCancel.TabIndex = 5
        Me.CmdCancel.Text = "&Cancel"
        '
        'ErrProvider
        '
        Me.ErrProvider.ContainerControl = Me
        '
        'FrmChooseDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 190)
        Me.Controls.Add(Me.TxtServer)
        Me.Controls.Add(Me.LblServer)
        Me.Controls.Add(Me.TxtDB)
        Me.Controls.Add(Me.LblDB)
        Me.Controls.Add(Me.TxtUser)
        Me.Controls.Add(Me.LblUserName)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.LblPass)
        Me.Controls.Add(Me.ChkIntSec)
        Me.Controls.Add(Me.LblIntSev)
        Me.Controls.Add(Me.CmdOK)
        Me.Controls.Add(Me.CmdCancel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmChooseDB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choose SQL Server Database"
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtServer As Textbox
Friend WithEvents LblServer As Label
Friend WithEvents TxtDB As Textbox
Friend WithEvents LblDB As Label
Friend WithEvents TxtUser As Textbox
Friend WithEvents LblUserName As Label
Friend WithEvents TxtPass As Textbox
Friend WithEvents LblPass As Label
Friend WithEvents ChkIntSec As System.Windows.Forms.Checkbox
Friend WithEvents LblIntSev As Label
Friend WithEvents CmdOK As System.Windows.Forms.Button
Friend WithEvents CmdCancel As System.Windows.Forms.Button

    Friend WithEvents ErrProvider As System.Windows.Forms.ErrorProvider
End Class
