<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.txtDotNetProjectPath = New System.Windows.Forms.TextBox()
        Me.txtDatabase = New System.Windows.Forms.TextBox()
        Me.lblSvnRoot = New System.Windows.Forms.Label()
        Me.lblDbPath = New System.Windows.Forms.Label()
        Me.txtResultsLog = New System.Windows.Forms.TextBox()
        Me.ofSelectFile = New System.Windows.Forms.OpenFileDialog()
        Me.btnSelectDotNetFolder = New System.Windows.Forms.Button()
        Me.btnSelectAccessDB = New System.Windows.Forms.Button()
        Me.fbSelectSVNFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.mnMain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsNewProject = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiOpenProject = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiSep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tmiExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiExportToText = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiCreateFromSVNSources = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboXMLConfFile = New System.Windows.Forms.ComboBox()
        Me.btnOpenConfig = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.sfdSaveConfig = New System.Windows.Forms.SaveFileDialog()
        Me.ucFormList = New AccessDotNetConverter.ucFormList()
        Me.mnMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDotNetProjectPath
        '
        Me.txtDotNetProjectPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDotNetProjectPath.Location = New System.Drawing.Point(142, 60)
        Me.txtDotNetProjectPath.Name = "txtDotNetProjectPath"
        Me.txtDotNetProjectPath.ReadOnly = True
        Me.txtDotNetProjectPath.Size = New System.Drawing.Size(832, 20)
        Me.txtDotNetProjectPath.TabIndex = 6
        '
        'txtDatabase
        '
        Me.txtDatabase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDatabase.Location = New System.Drawing.Point(142, 84)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.ReadOnly = True
        Me.txtDatabase.Size = New System.Drawing.Size(832, 20)
        Me.txtDatabase.TabIndex = 9
        '
        'lblSvnRoot
        '
        Me.lblSvnRoot.AutoSize = True
        Me.lblSvnRoot.Location = New System.Drawing.Point(13, 63)
        Me.lblSvnRoot.Name = "lblSvnRoot"
        Me.lblSvnRoot.Size = New System.Drawing.Size(126, 13)
        Me.lblSvnRoot.TabIndex = 5
        Me.lblSvnRoot.Text = ".NET Root Project Folder"
        '
        'lblDbPath
        '
        Me.lblDbPath.AutoSize = True
        Me.lblDbPath.Location = New System.Drawing.Point(17, 87)
        Me.lblDbPath.Name = "lblDbPath"
        Me.lblDbPath.Size = New System.Drawing.Size(122, 13)
        Me.lblDbPath.TabIndex = 8
        Me.lblDbPath.Text = "Source Access DB Path"
        '
        'txtResultsLog
        '
        Me.txtResultsLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtResultsLog.Location = New System.Drawing.Point(317, 154)
        Me.txtResultsLog.Multiline = True
        Me.txtResultsLog.Name = "txtResultsLog"
        Me.txtResultsLog.ReadOnly = True
        Me.txtResultsLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResultsLog.Size = New System.Drawing.Size(700, 267)
        Me.txtResultsLog.TabIndex = 12
        '
        'ofSelectFile
        '
        Me.ofSelectFile.FileName = "OpenFileDialog1"
        '
        'btnSelectDotNetFolder
        '
        Me.btnSelectDotNetFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectDotNetFolder.Location = New System.Drawing.Point(980, 58)
        Me.btnSelectDotNetFolder.Name = "btnSelectDotNetFolder"
        Me.btnSelectDotNetFolder.Size = New System.Drawing.Size(37, 22)
        Me.btnSelectDotNetFolder.TabIndex = 7
        Me.btnSelectDotNetFolder.Text = "..."
        Me.btnSelectDotNetFolder.UseVisualStyleBackColor = True
        '
        'btnSelectAccessDB
        '
        Me.btnSelectAccessDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectAccessDB.Location = New System.Drawing.Point(980, 82)
        Me.btnSelectAccessDB.Name = "btnSelectAccessDB"
        Me.btnSelectAccessDB.Size = New System.Drawing.Size(37, 22)
        Me.btnSelectAccessDB.TabIndex = 10
        Me.btnSelectAccessDB.Text = "..."
        Me.btnSelectAccessDB.UseVisualStyleBackColor = True
        '
        'fbSelectSVNFolder
        '
        Me.fbSelectSVNFolder.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'mnMain
        '
        Me.mnMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.mnMain.Location = New System.Drawing.Point(0, 0)
        Me.mnMain.Name = "mnMain"
        Me.mnMain.Size = New System.Drawing.Size(1046, 24)
        Me.mnMain.TabIndex = 0
        Me.mnMain.Text = "mnMain"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsNewProject, Me.tsmiOpenProject, Me.tsmiSave, Me.tmiSep1, Me.tmiExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'tsNewProject
        '
        Me.tsNewProject.Name = "tsNewProject"
        Me.tsNewProject.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.tsNewProject.Size = New System.Drawing.Size(186, 22)
        Me.tsNewProject.Text = "&New Project"
        '
        'tsmiOpenProject
        '
        Me.tsmiOpenProject.Name = "tsmiOpenProject"
        Me.tsmiOpenProject.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.tsmiOpenProject.Size = New System.Drawing.Size(186, 22)
        Me.tsmiOpenProject.Text = "&Open Project"
        '
        'tsmiSave
        '
        Me.tsmiSave.Name = "tsmiSave"
        Me.tsmiSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.tsmiSave.Size = New System.Drawing.Size(186, 22)
        Me.tsmiSave.Text = "Save &Project"
        '
        'tmiSep1
        '
        Me.tmiSep1.Name = "tmiSep1"
        Me.tmiSep1.Size = New System.Drawing.Size(183, 6)
        '
        'tmiExit
        '
        Me.tmiExit.Name = "tmiExit"
        Me.tmiExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.tmiExit.Size = New System.Drawing.Size(186, 22)
        Me.tmiExit.Text = "E&xit"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tmiExportToText, Me.tmiCreateFromSVNSources, Me.ToolStripSeparator1})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(59, 20)
        Me.ToolStripMenuItem1.Text = "Actions"
        '
        'tmiExportToText
        '
        Me.tmiExportToText.Name = "tmiExportToText"
        Me.tmiExportToText.Size = New System.Drawing.Size(208, 22)
        Me.tmiExportToText.Text = "Export To Text"
        '
        'tmiCreateFromSVNSources
        '
        Me.tmiCreateFromSVNSources.Name = "tmiCreateFromSVNSources"
        Me.tmiCreateFromSVNSources.Size = New System.Drawing.Size(208, 22)
        Me.tmiCreateFromSVNSources.Text = "Create From SVN Sources"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(205, 6)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Config File"
        '
        'cboXMLConfFile
        '
        Me.cboXMLConfFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboXMLConfFile.BackColor = System.Drawing.SystemColors.Control
        Me.cboXMLConfFile.Location = New System.Drawing.Point(142, 34)
        Me.cboXMLConfFile.Name = "cboXMLConfFile"
        Me.cboXMLConfFile.Size = New System.Drawing.Size(832, 21)
        Me.cboXMLConfFile.TabIndex = 3
        '
        'btnOpenConfig
        '
        Me.btnOpenConfig.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpenConfig.Location = New System.Drawing.Point(980, 32)
        Me.btnOpenConfig.Name = "btnOpenConfig"
        Me.btnOpenConfig.Size = New System.Drawing.Size(37, 22)
        Me.btnOpenConfig.TabIndex = 4
        Me.btnOpenConfig.Text = "..."
        Me.btnOpenConfig.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(317, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Log:"
        '
        'ucFormList
        '
        Me.ucFormList.Location = New System.Drawing.Point(16, 154)
        Me.ucFormList.Name = "ucFormList"
        Me.ucFormList.Size = New System.Drawing.Size(274, 267)
        Me.ucFormList.TabIndex = 0
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 433)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ucFormList)
        Me.Controls.Add(Me.btnOpenConfig)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboXMLConfFile)
        Me.Controls.Add(Me.btnSelectAccessDB)
        Me.Controls.Add(Me.btnSelectDotNetFolder)
        Me.Controls.Add(Me.txtResultsLog)
        Me.Controls.Add(Me.lblDbPath)
        Me.Controls.Add(Me.lblSvnRoot)
        Me.Controls.Add(Me.txtDatabase)
        Me.Controls.Add(Me.txtDotNetProjectPath)
        Me.Controls.Add(Me.mnMain)
        Me.MainMenuStrip = Me.mnMain
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Access To .Net Forms Converter"
        Me.mnMain.ResumeLayout(False)
        Me.mnMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDotNetProjectPath As System.Windows.Forms.TextBox
    Friend WithEvents txtDatabase As System.Windows.Forms.TextBox
    Friend WithEvents lblSvnRoot As System.Windows.Forms.Label
    Friend WithEvents lblDbPath As System.Windows.Forms.Label
    Friend WithEvents txtResultsLog As System.Windows.Forms.TextBox
    Friend WithEvents ofSelectFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnSelectDotNetFolder As System.Windows.Forms.Button
    Friend WithEvents btnSelectAccessDB As System.Windows.Forms.Button
    Friend WithEvents fbSelectSVNFolder As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents mnMain As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiOpenProject As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmiExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmiExportToText As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmiCreateFromSVNSources As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsNewProject As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmiSep1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboXMLConfFile As System.Windows.Forms.ComboBox
    Friend WithEvents btnOpenConfig As System.Windows.Forms.Button
    Friend WithEvents ucFormList As ucFormList
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents sfdSaveConfig As System.Windows.Forms.SaveFileDialog

End Class
