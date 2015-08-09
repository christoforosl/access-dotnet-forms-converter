'
' Form converted from MSAccess database using AccessDotNetConverter on Friday, April 18, 2014
' https://code.google.com/p/msaccess-subversion-control
' 
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMessageBox
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
		
		 Me.CmdYes = New System.Windows.Forms.Button
Me.CmdNo = New System.Windows.Forms.Button
Me.ImgInfo = New System.Windows.Forms.PictureBox
Me.ImgQn = New System.Windows.Forms.PictureBox
Me.ImgMessage = New System.Windows.Forms.PictureBox
Me.LblMessage = New Textbox
Me.CmdPrint = New System.Windows.Forms.Button

        Me.SuspendLayout()
		
		Me.ErrProvider = New System.Windows.Forms.ErrorProvider()
 
	   'do tab pages here
        
Me.CmdYes.Name = "CmdYes"
Me.CmdYes.Location = New System.Drawing.Point(308, 325)
Me.CmdYes.Size = New System.Drawing.Size(82, 29)
Me.CmdYes.Visible=True
me.CmdYes.TabIndex = 0
me.CmdYes.Font = New System.Drawing.Font("Tahoma", 10!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.CmdYes.Text = ""
Me.CmdYes.forecolor = System.Drawing.ColorTranslator.FromOle(-2147483630)
Me.CmdNo.Name = "CmdNo"
Me.CmdNo.Location = New System.Drawing.Point(392, 325)
Me.CmdNo.Size = New System.Drawing.Size(82, 29)
Me.CmdNo.Visible=True
me.CmdNo.TabIndex = 1
me.CmdNo.Font = New System.Drawing.Font("Tahoma", 10!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.CmdNo.Text = ""
Me.CmdNo.forecolor = System.Drawing.ColorTranslator.FromOle(-2147483630)
Me.ImgInfo.Name = "ImgInfo"
Me.ImgInfo.Location = New System.Drawing.Point(725, 123)
Me.ImgInfo.Size = New System.Drawing.Size(46, 46)
Me.ImgInfo.Visible=False
Me.ImgQn.Name = "ImgQn"
Me.ImgQn.Location = New System.Drawing.Point(725, 8)
Me.ImgQn.Size = New System.Drawing.Size(46, 46)
Me.ImgQn.Visible=True
Me.ImgMessage.Name = "ImgMessage"
Me.ImgMessage.Location = New System.Drawing.Point(725, 8)
Me.ImgMessage.Size = New System.Drawing.Size(46, 46)
Me.ImgMessage.Visible=False
Me.LblMessage.Name = "LblMessage"
Me.LblMessage.Location = New System.Drawing.Point(11, 8)
Me.LblMessage.Size = New System.Drawing.Size(709, 312)
Me.LblMessage.Visible=True
me.LblMessage.TabIndex = 2
me.LblMessage.Font = New System.Drawing.Font("Arial", 10!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.LblMessage.Multiline = True
me.LblMessage.ReadOnly = True
Me.LblMessage.TextAlign=HorizontalAlignment.Left


Me.CmdPrint.Name = "CmdPrint"
Me.CmdPrint.Location = New System.Drawing.Point(610, 325)
Me.CmdPrint.Size = New System.Drawing.Size(109, 29)
Me.CmdPrint.Visible=True
me.CmdPrint.TabIndex = 3
me.CmdPrint.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.CmdPrint.Text = "&Print"
Me.CmdPrint.forecolor = System.Drawing.ColorTranslator.FromOle(-2147483630)
       
		
		Me.ErrProvider.ContainerControl = Me
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        
        
Me.controls.add(me.CmdYes)
Me.controls.add(me.CmdNo)
Me.controls.add(me.ImgInfo)
Me.controls.add(me.ImgQn)
Me.controls.add(me.ImgMessage)
Me.controls.add(me.LblMessage)
Me.controls.add(me.CmdPrint)
        
        Me.Name = "FrmMessageBox"
        Me.Text = "Κυπριακό Μισθολόγιο [ 2.87 ]"
		Me.ClientSize = New System.Drawing.Size(782, 359)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	
	End Sub

    Friend WithEvents CmdYes As System.Windows.Forms.Button
Friend WithEvents CmdNo As System.Windows.Forms.Button
Friend WithEvents ImgInfo As System.Windows.Forms.PictureBox
Friend WithEvents ImgQn As System.Windows.Forms.PictureBox
Friend WithEvents ImgMessage As System.Windows.Forms.PictureBox
Friend WithEvents LblMessage As Textbox
Friend WithEvents CmdPrint As System.Windows.Forms.Button

    Friend WithEvents ErrProvider As System.Windows.Forms.ErrorProvider
End Class
