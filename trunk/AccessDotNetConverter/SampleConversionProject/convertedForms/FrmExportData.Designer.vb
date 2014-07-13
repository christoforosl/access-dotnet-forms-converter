'
' Form converted from MSAccess database using AccessDotNetConverter on Tuesday, April 08, 2014
' https://code.google.com/p/msaccess-subversion-control
' 
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExportData
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
        Me.CmdContinue = New System.Windows.Forms.Button()
        Me.QbexportHelpLabel = New System.Windows.Forms.Label()
        Me.CmdSelectFolder = New System.Windows.Forms.Button()
        Me.TxtExportFolder = New System.Windows.Forms.TextBox()
        Me.ExportfolderLabel = New System.Windows.Forms.Label()
        Me.TxtExportFileName = New System.Windows.Forms.TextBox()
        Me.ExportFileNameLabel = New System.Windows.Forms.Label()
        Me.SkipExorted = New System.Windows.Forms.CheckBox()
        Me.SkipExortedLabel = New System.Windows.Forms.Label()
        Me.MarkExportedLocked = New System.Windows.Forms.CheckBox()
        Me.MarkExportedLockedLabel = New System.Windows.Forms.Label()
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.ErrProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdContinue
        '
        Me.CmdContinue.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.CmdContinue.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdContinue.Location = New System.Drawing.Point(474, 256)
        Me.CmdContinue.Name = "CmdContinue"
        Me.CmdContinue.Size = New System.Drawing.Size(77, 28)
        Me.CmdContinue.TabIndex = 0
        Me.CmdContinue.Text = "&Συνέχεια"
        '
        'QbexportHelpLabel
        '
        Me.QbexportHelpLabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.QbexportHelpLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.QbexportHelpLabel.Location = New System.Drawing.Point(11, 18)
        Me.QbexportHelpLabel.Name = "QbexportHelpLabel"
        Me.QbexportHelpLabel.Size = New System.Drawing.Size(540, 48)
        Me.QbexportHelpLabel.TabIndex = 1
        Me.QbexportHelpLabel.Text = "Η διαδικασία αυτή θα δημιουργήσει αρχείο με πληροφορίες για τις επιλεγμένες εγγρα" & _
    "φές.  Το αρχείο αυτό μπορείτε να το εισάγετε στο QuickBooks για να ενημερώσετε τ" & _
    "ο λογιστικό σας σύστημα."
        Me.QbexportHelpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmdSelectFolder
        '
        Me.CmdSelectFolder.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.CmdSelectFolder.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdSelectFolder.Location = New System.Drawing.Point(523, 111)
        Me.CmdSelectFolder.Name = "CmdSelectFolder"
        Me.CmdSelectFolder.Size = New System.Drawing.Size(28, 20)
        Me.CmdSelectFolder.TabIndex = 3
        Me.CmdSelectFolder.Text = "…"
        '
        'TxtExportFolder
        '
        Me.TxtExportFolder.BackColor = Me.BackColor
        Me.TxtExportFolder.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.TxtExportFolder.Location = New System.Drawing.Point(41, 112)
        Me.TxtExportFolder.Name = "TxtExportFolder"
        Me.TxtExportFolder.ReadOnly = True
        Me.TxtExportFolder.Size = New System.Drawing.Size(476, 20)
        Me.TxtExportFolder.TabIndex = 1
        '
        'ExportfolderLabel
        '
        Me.ExportfolderLabel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.ExportfolderLabel.Location = New System.Drawing.Point(11, 94)
        Me.ExportfolderLabel.Name = "ExportfolderLabel"
        Me.ExportfolderLabel.Size = New System.Drawing.Size(433, 17)
        Me.ExportfolderLabel.TabIndex = 4
        Me.ExportfolderLabel.Text = "Φάκελος (Folder) δημιουργίας αρχείων"
        Me.ExportfolderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtExportFileName
        '
        Me.TxtExportFileName.BackColor = Me.BackColor
        Me.TxtExportFileName.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.TxtExportFileName.Location = New System.Drawing.Point(43, 158)
        Me.TxtExportFileName.Name = "TxtExportFileName"
        Me.TxtExportFileName.ReadOnly = True
        Me.TxtExportFileName.Size = New System.Drawing.Size(476, 20)
        Me.TxtExportFileName.TabIndex = 4
        '
        'ExportFileNameLabel
        '
        Me.ExportFileNameLabel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.ExportFileNameLabel.Location = New System.Drawing.Point(11, 140)
        Me.ExportFileNameLabel.Name = "ExportFileNameLabel"
        Me.ExportFileNameLabel.Size = New System.Drawing.Size(433, 17)
        Me.ExportFileNameLabel.TabIndex = 5
        Me.ExportFileNameLabel.Text = "Όνομα Αρχείου"
        Me.ExportFileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SkipExorted
        '
        Me.SkipExorted.Location = New System.Drawing.Point(26, 192)
        Me.SkipExorted.Name = "SkipExorted"
        Me.SkipExorted.Size = New System.Drawing.Size(14, 14)
        Me.SkipExorted.TabIndex = 5
        '
        'SkipExortedLabel
        '
        Me.SkipExortedLabel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.SkipExortedLabel.Location = New System.Drawing.Point(41, 190)
        Me.SkipExortedLabel.Name = "SkipExortedLabel"
        Me.SkipExortedLabel.Size = New System.Drawing.Size(321, 16)
        Me.SkipExortedLabel.TabIndex = 6
        Me.SkipExortedLabel.Text = "Παράληψη εγγραφών που έχουν ήδη εξαχθεί."
        Me.SkipExortedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MarkExportedLocked
        '
        Me.MarkExportedLocked.Location = New System.Drawing.Point(26, 212)
        Me.MarkExportedLocked.Name = "MarkExportedLocked"
        Me.MarkExportedLocked.Size = New System.Drawing.Size(14, 14)
        Me.MarkExportedLocked.TabIndex = 6
        '
        'MarkExportedLockedLabel
        '
        Me.MarkExportedLockedLabel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.MarkExportedLockedLabel.Location = New System.Drawing.Point(41, 210)
        Me.MarkExportedLockedLabel.Name = "MarkExportedLockedLabel"
        Me.MarkExportedLockedLabel.Size = New System.Drawing.Size(321, 16)
        Me.MarkExportedLockedLabel.TabIndex = 7
        Me.MarkExportedLockedLabel.Text = "Σήμανση εξαγόμενων εγγραφών ως κλειδωμένες."
        Me.MarkExportedLockedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmdCancel
        '
        Me.CmdCancel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.CmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdCancel.Location = New System.Drawing.Point(389, 256)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(77, 28)
        Me.CmdCancel.TabIndex = 2
        Me.CmdCancel.Text = "Ακύρωση"
        '
        'ErrProvider
        '
        Me.ErrProvider.ContainerControl = Me
        '
        'FrmQBExport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 296)
        Me.Controls.Add(Me.CmdContinue)
        Me.Controls.Add(Me.QbexportHelpLabel)
        Me.Controls.Add(Me.CmdSelectFolder)
        Me.Controls.Add(Me.TxtExportFolder)
        Me.Controls.Add(Me.ExportfolderLabel)
        Me.Controls.Add(Me.TxtExportFileName)
        Me.Controls.Add(Me.ExportFileNameLabel)
        Me.Controls.Add(Me.SkipExorted)
        Me.Controls.Add(Me.SkipExortedLabel)
        Me.Controls.Add(Me.MarkExportedLocked)
        Me.Controls.Add(Me.MarkExportedLockedLabel)
        Me.Controls.Add(Me.CmdCancel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmQBExport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Εξαγωγή Πληροφοριών στο Quickbooks"
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmdContinue As System.Windows.Forms.Button
    Friend WithEvents QbexportHelpLabel As Label
    Friend WithEvents CmdSelectFolder As System.Windows.Forms.Button
    Friend WithEvents TxtExportFolder As Textbox
    Friend WithEvents ExportfolderLabel As Label
    Friend WithEvents TxtExportFileName As Textbox
    Friend WithEvents ExportFileNameLabel As Label
    Friend WithEvents SkipExorted As System.Windows.Forms.Checkbox
    Friend WithEvents SkipExortedLabel As Label
    Friend WithEvents MarkExportedLocked As System.Windows.Forms.Checkbox
    Friend WithEvents MarkExportedLockedLabel As Label
    Friend WithEvents CmdCancel As System.Windows.Forms.Button

    Friend WithEvents ErrProvider As System.Windows.Forms.ErrorProvider
End Class
