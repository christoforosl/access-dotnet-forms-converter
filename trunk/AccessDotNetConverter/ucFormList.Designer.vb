<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucFormList
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucFormList))
        Me.tspMain = New System.Windows.Forms.ToolStrip()
        Me.btnRunConversion = New System.Windows.Forms.ToolStripButton()
        Me.btnButton2 = New System.Windows.Forms.ToolStripButton()
        Me.btnButton3 = New System.Windows.Forms.ToolStripButton()
        Me.lstForms = New System.Windows.Forms.ListBox()
        Me.tspMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'tspMain
        '
        Me.tspMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnRunConversion, Me.btnButton2, Me.btnButton3})
        Me.tspMain.Location = New System.Drawing.Point(0, 0)
        Me.tspMain.Name = "tspMain"
        Me.tspMain.Size = New System.Drawing.Size(274, 25)
        Me.tspMain.TabIndex = 2
        Me.tspMain.Text = "ToolStrip1"
        '
        'btnCreateWorkFile
        '
        Me.btnRunConversion.Image = CType(resources.GetObject("btnCreateWorkFile.Image"), System.Drawing.Image)
        Me.btnRunConversion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRunConversion.Name = "btnCreateWorkFile"
        Me.btnRunConversion.Size = New System.Drawing.Size(105, 22)
        Me.btnRunConversion.Text = "Convert Forms"
        '
        'btnButton2
        '
        Me.btnButton2.Image = CType(resources.GetObject("btnButton2.Image"), System.Drawing.Image)
        Me.btnButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnButton2.Name = "btnButton2"
        Me.btnButton2.Size = New System.Drawing.Size(69, 22)
        Me.btnButton2.Text = "Button2"
        Me.btnButton2.Visible = False
        '
        'btnButton3
        '
        Me.btnButton3.Image = CType(resources.GetObject("btnButton3.Image"), System.Drawing.Image)
        Me.btnButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnButton3.Name = "btnButton3"
        Me.btnButton3.Size = New System.Drawing.Size(69, 22)
        Me.btnButton3.Text = "Button3"
        Me.btnButton3.Visible = False
        '
        'lstForms
        '
        Me.lstForms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstForms.FormattingEnabled = True
        Me.lstForms.Location = New System.Drawing.Point(0, 25)
        Me.lstForms.Name = "lstForms"
        Me.lstForms.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstForms.Size = New System.Drawing.Size(274, 200)
        Me.lstForms.TabIndex = 12
        '
        'usFormList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lstForms)
        Me.Controls.Add(Me.tspMain)
        Me.Name = "usFormList"
        Me.Size = New System.Drawing.Size(274, 225)
        Me.tspMain.ResumeLayout(False)
        Me.tspMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents tspMain As System.Windows.Forms.ToolStrip
    Public WithEvents btnRunConversion As System.Windows.Forms.ToolStripButton
    Public WithEvents btnButton2 As System.Windows.Forms.ToolStripButton
    Public WithEvents btnButton3 As System.Windows.Forms.ToolStripButton
    Public WithEvents lstForms As System.Windows.Forms.ListBox

End Class
