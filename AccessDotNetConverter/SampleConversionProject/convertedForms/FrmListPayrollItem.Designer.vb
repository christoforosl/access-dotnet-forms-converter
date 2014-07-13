'
' Form converted from MSAccess database using AccessDotNetConverter on 13 July 2014
' https://code.google.com/p/msaccess-subversion-control
' 
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListPayrollItem
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
		
		 Me.CboShowCat = New ConvertedMSAccessControls.AccessCombo
Me.PayrollTypeIDLabel1 = New Label
Me.ActiveOnly = New System.Windows.Forms.Checkbox
Me.ActiveOnlyLabel = New Label
Me.DataGridCntrl = New System.Windows.Forms.DataGridView
Me.CboAccount = New ConvertedMSAccessControls.AccessCombo
Me.AccountLabel = New Label
Me.CboAccountCode = New ConvertedMSAccessControls.AccessCombo
Me.Label23 = New Label

        Me.SuspendLayout()
		
		Me.ErrProvider = New System.Windows.Forms.ErrorProvider()
 
	   'do tab pages here
        
Me.CboShowCat.Name = "CboShowCat"
Me.CboShowCat.Location = New System.Drawing.Point(211, 8)
Me.CboShowCat.Size = New System.Drawing.Size(96, 16)
Me.CboShowCat.Visible=True
me.CboShowCat.TabIndex = 1
me.CboShowCat.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.CboShowCat.RowSourceType = "Table/Query"
me.CboShowCat.RowSource = "vPickListPICategory"

Me.PayrollTypeIDLabel1.Name = "PayrollTypeIDLabel1"
Me.PayrollTypeIDLabel1.Location = New System.Drawing.Point(128, 8)
Me.PayrollTypeIDLabel1.Size = New System.Drawing.Size(76, 16)
Me.PayrollTypeIDLabel1.Visible=True
me.PayrollTypeIDLabel1.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.PayrollTypeIDLabel1.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.PayrollTypeIDLabel1.Text = "Κατηγορία"


Me.ActiveOnly.Name = "ActiveOnly"
Me.ActiveOnly.Location = New System.Drawing.Point(16, 10)
Me.ActiveOnly.Size = New System.Drawing.Size(14, 14)
Me.ActiveOnly.Visible=True
me.ActiveOnly.TabIndex = 0
Me.ActiveOnlyLabel.Name = "ActiveOnlyLabel"
Me.ActiveOnlyLabel.Location = New System.Drawing.Point(31, 8)
Me.ActiveOnlyLabel.Size = New System.Drawing.Size(136, 17)
Me.ActiveOnlyLabel.Visible=True
me.ActiveOnlyLabel.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.ActiveOnlyLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft
Me.ActiveOnlyLabel.Text = "Ενεργά Μόνον"


Me.DataGridCntrl.Name = "DataGridCntrl"
Me.DataGridCntrl.Location = New System.Drawing.Point(8, 34)
Me.DataGridCntrl.Size = New System.Drawing.Size(770, 370)
Me.DataGridCntrl.Visible=True
me.DataGridCntrl.TabIndex = 2
Me.CboAccount.Name = "CboAccount"
Me.CboAccount.Location = New System.Drawing.Point(395, 8)
Me.CboAccount.Size = New System.Drawing.Size(122, 16)
Me.CboAccount.Visible=True
me.CboAccount.TabIndex = 3
me.CboAccount.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.CboAccount.RowSourceType = "Table/Query"
me.CboAccount.RowSource = "vPickListAccounts"

Me.AccountLabel.Name = "AccountLabel"
Me.AccountLabel.Location = New System.Drawing.Point(312, 8)
Me.AccountLabel.Size = New System.Drawing.Size(76, 16)
Me.AccountLabel.Visible=True
me.AccountLabel.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.AccountLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.AccountLabel.Text = "Λογαριασμός"


Me.CboAccountCode.Name = "CboAccountCode"
Me.CboAccountCode.Location = New System.Drawing.Point(603, 8)
Me.CboAccountCode.Size = New System.Drawing.Size(122, 16)
Me.CboAccountCode.Visible=True
me.CboAccountCode.TabIndex = 4
me.CboAccountCode.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.CboAccountCode.RowSourceType = "Table/Query"
me.CboAccountCode.RowSource = "SELECT DISTINCT Account.account FROM Account ORDER BY 1; "

Me.Label23.Name = "Label23"
Me.Label23.Location = New System.Drawing.Point(520, 8)
Me.Label23.Size = New System.Drawing.Size(76, 16)
Me.Label23.Visible=True
me.Label23.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.Label23.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.Label23.Text = "Κωδικός Λογ."


       
		
		Me.ErrProvider.ContainerControl = Me
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        
        
Me.controls.add(me.CboShowCat)
Me.controls.add(me.PayrollTypeIDLabel1)
Me.controls.add(me.ActiveOnly)
Me.controls.add(me.ActiveOnlyLabel)
Me.controls.add(me.DataGridCntrl)
Me.controls.add(me.CboAccount)
Me.controls.add(me.AccountLabel)
Me.controls.add(me.CboAccountCode)
Me.controls.add(me.Label23)
        
        Me.Name = "FrmListPayrollItem"
        Me.Text = " Μισθολογικά Είδη"
		Me.ClientSize = New System.Drawing.Size(1348, 729)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	
	End Sub

    Friend WithEvents CboShowCat As ConvertedMSAccessControls.AccessCombo
Friend WithEvents PayrollTypeIDLabel1 As Label
Friend WithEvents ActiveOnly As System.Windows.Forms.Checkbox
Friend WithEvents ActiveOnlyLabel As Label
Friend WithEvents DataGridCntrl As System.Windows.Forms.DataGridView
Friend WithEvents CboAccount As ConvertedMSAccessControls.AccessCombo
Friend WithEvents AccountLabel As Label
Friend WithEvents CboAccountCode As ConvertedMSAccessControls.AccessCombo
Friend WithEvents Label23 As Label

    Friend WithEvents ErrProvider As System.Windows.Forms.ErrorProvider
End Class
