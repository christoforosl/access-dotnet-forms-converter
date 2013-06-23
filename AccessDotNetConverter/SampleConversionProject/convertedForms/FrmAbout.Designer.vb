'
' Form converted from MSAccess database using AccessDotNetConverter on Sunday, June 23, 2013
' https://code.google.com/p/msaccess-subversion-control
' 
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAbout
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
		
		 Me.Serial = New Textbox
Me.SerialnoLabel = New Label
Me.Text10 = New Textbox
Me.DatabaseLabel = New Label
Me.Text12 = New Textbox
Me.Label13 = New Label
Me.NumEmployees = New Textbox
Me.NumberOfEmployeesLabel = New Label
Me.Text17 = New Textbox
Me.NumberPaychecksLabel = New Label
Me.Text0 = New Textbox
Me.Label1 = New Label
Me.LatestPaycheck = New DateTimePicker
Me.LatestPacheckLabel = New Label
Me.EarliestPaycheck = New DateTimePicker
Me.EarliestPaycheckLabel = New Label
Me.TotalWorkdays = New Textbox
Me.TotalWorkDaysLabel = New Label
Me.TotalHours = New Textbox
Me.TotalWorkHoursLabel = New Label
Me.Regcode = New Textbox
Me.RegCodeLabel = New Label
Me.CmdRegister = New System.Windows.Forms.Button
Me.EmployeeLimit = New Textbox
Me.EmployeeLimitLabel = New Label
Me.Image14 = New System.Windows.Forms.PictureBox
Me.WarningLabel = New Label
Me.CmdClearSortKeys = New System.Windows.Forms.Button
Me.LblEval = New Label
Me.CmdFixQueries = New System.Windows.Forms.Button
Me.CmdCheckPayrollItems = New System.Windows.Forms.Button
Me.CmdInstallNewDeployer = New System.Windows.Forms.Button
Me.CmdstartLogging = New System.Windows.Forms.Button

        Me.SuspendLayout()
		
		Me.ErrProvider = New System.Windows.Forms.ErrorProvider()
 
	   'do tab pages here
        
Me.Serial.Name = "Serial"
Me.Serial.Location = New System.Drawing.Point(323, 136)
Me.Serial.Size = New System.Drawing.Size(139, 16)
Me.Serial.Visible=True
me.Serial.TabIndex = 2
me.Serial.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Serial.ReadOnly = True
Me.Serial.TextAlign=HorizontalAlignment.Left


Me.SerialnoLabel.Name = "SerialnoLabel"
Me.SerialnoLabel.Location = New System.Drawing.Point(189, 136)
Me.SerialnoLabel.Size = New System.Drawing.Size(130, 16)
Me.SerialnoLabel.Visible=True
me.SerialnoLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.SerialnoLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.SerialnoLabel.Text = "Αρ. Λογισμικού"


Me.Text10.Name = "Text10"
Me.Text10.Location = New System.Drawing.Point(323, 178)
Me.Text10.Size = New System.Drawing.Size(254, 16)
Me.Text10.Visible=True
me.Text10.TabIndex = 4
me.Text10.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Text10.ReadOnly = True
Me.Text10.TextAlign=HorizontalAlignment.Left


Me.DatabaseLabel.Name = "DatabaseLabel"
Me.DatabaseLabel.Location = New System.Drawing.Point(189, 178)
Me.DatabaseLabel.Size = New System.Drawing.Size(130, 16)
Me.DatabaseLabel.Visible=True
me.DatabaseLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.DatabaseLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.DatabaseLabel.Text = "Βάση Δεδομένων"


Me.Text12.Name = "Text12"
Me.Text12.Location = New System.Drawing.Point(323, 199)
Me.Text12.Size = New System.Drawing.Size(139, 16)
Me.Text12.Visible=True
me.Text12.TabIndex = 5
me.Text12.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Text12.ReadOnly = True
Me.Text12.TextAlign=HorizontalAlignment.Left


Me.Label13.Name = "Label13"
Me.Label13.Location = New System.Drawing.Point(189, 199)
Me.Label13.Size = New System.Drawing.Size(130, 16)
Me.Label13.Visible=True
me.Label13.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.Label13.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.Label13.Text = "Program Version"


Me.NumEmployees.Name = "NumEmployees"
Me.NumEmployees.Location = New System.Drawing.Point(155, 285)
Me.NumEmployees.Size = New System.Drawing.Size(129, 16)
Me.NumEmployees.Visible=True
me.NumEmployees.TabIndex = 7
me.NumEmployees.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.NumEmployees.ReadOnly = True
me.NumEmployees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.NumEmployees.TextAlign=HorizontalAlignment.Left


Me.NumberOfEmployeesLabel.Name = "NumberOfEmployeesLabel"
Me.NumberOfEmployeesLabel.Location = New System.Drawing.Point(14, 285)
Me.NumberOfEmployeesLabel.Size = New System.Drawing.Size(138, 16)
Me.NumberOfEmployeesLabel.Visible=True
me.NumberOfEmployeesLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.NumberOfEmployeesLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.NumberOfEmployeesLabel.Text = "Αρ. Υπαλλήλων"


Me.Text17.Name = "Text17"
Me.Text17.Location = New System.Drawing.Point(155, 306)
Me.Text17.Size = New System.Drawing.Size(129, 16)
Me.Text17.Visible=True
me.Text17.TabIndex = 9
me.Text17.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Text17.ReadOnly = True
me.Text17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.Text17.TextAlign=HorizontalAlignment.Left


Me.NumberPaychecksLabel.Name = "NumberPaychecksLabel"
Me.NumberPaychecksLabel.Location = New System.Drawing.Point(14, 306)
Me.NumberPaychecksLabel.Size = New System.Drawing.Size(138, 16)
Me.NumberPaychecksLabel.Visible=True
me.NumberPaychecksLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.NumberPaychecksLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.NumberPaychecksLabel.Text = "Αρ. Πληρωμών"


Me.Text0.Name = "Text0"
Me.Text0.Location = New System.Drawing.Point(323, 219)
Me.Text0.Size = New System.Drawing.Size(139, 16)
Me.Text0.Visible=True
me.Text0.TabIndex = 6
me.Text0.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Text0.ReadOnly = True
Me.Text0.TextAlign=HorizontalAlignment.Left


Me.Label1.Name = "Label1"
Me.Label1.Location = New System.Drawing.Point(189, 219)
Me.Label1.Size = New System.Drawing.Size(130, 16)
Me.Label1.Visible=True
me.Label1.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.Label1.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.Label1.Text = "Database Version"


Me.LatestPaycheck.Name = "LatestPaycheck"
Me.LatestPaycheck.Location = New System.Drawing.Point(452, 285)
Me.LatestPaycheck.Size = New System.Drawing.Size(103, 16)
Me.LatestPaycheck.Visible=True
me.LatestPaycheck.TabIndex = 8
me.LatestPaycheck.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))

Me.LatestPacheckLabel.Name = "LatestPacheckLabel"
Me.LatestPacheckLabel.Location = New System.Drawing.Point(291, 285)
Me.LatestPacheckLabel.Size = New System.Drawing.Size(157, 16)
Me.LatestPacheckLabel.Visible=True
me.LatestPacheckLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.LatestPacheckLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.LatestPacheckLabel.Text = "Ημέρα Πιο Πρόσφατου Μισθού"


Me.EarliestPaycheck.Name = "EarliestPaycheck"
Me.EarliestPaycheck.Location = New System.Drawing.Point(452, 306)
Me.EarliestPaycheck.Size = New System.Drawing.Size(103, 16)
Me.EarliestPaycheck.Visible=True
me.EarliestPaycheck.TabIndex = 10
me.EarliestPaycheck.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))

Me.EarliestPaycheckLabel.Name = "EarliestPaycheckLabel"
Me.EarliestPaycheckLabel.Location = New System.Drawing.Point(291, 306)
Me.EarliestPaycheckLabel.Size = New System.Drawing.Size(157, 16)
Me.EarliestPaycheckLabel.Visible=True
me.EarliestPaycheckLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.EarliestPaycheckLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.EarliestPaycheckLabel.Text = "Ημέρα Παλαιοτέρου Μισθού"


Me.TotalWorkdays.Name = "TotalWorkdays"
Me.TotalWorkdays.Location = New System.Drawing.Point(452, 326)
Me.TotalWorkdays.Size = New System.Drawing.Size(103, 16)
Me.TotalWorkdays.Visible=True
me.TotalWorkdays.TabIndex = 11
me.TotalWorkdays.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.TotalWorkdays.ReadOnly = True
me.TotalWorkdays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.TotalWorkdays.TextAlign=HorizontalAlignment.Left


Me.TotalWorkDaysLabel.Name = "TotalWorkDaysLabel"
Me.TotalWorkDaysLabel.Location = New System.Drawing.Point(294, 326)
Me.TotalWorkDaysLabel.Size = New System.Drawing.Size(154, 16)
Me.TotalWorkDaysLabel.Visible=True
me.TotalWorkDaysLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.TotalWorkDaysLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.TotalWorkDaysLabel.Text = "Ημέρες Εργασίας (Ολικό)"


Me.TotalHours.Name = "TotalHours"
Me.TotalHours.Location = New System.Drawing.Point(156, 327)
Me.TotalHours.Size = New System.Drawing.Size(129, 16)
Me.TotalHours.Visible=True
me.TotalHours.TabIndex = 12
me.TotalHours.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.TotalHours.ReadOnly = True
me.TotalHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.TotalHours.TextAlign=HorizontalAlignment.Left


Me.TotalWorkHoursLabel.Name = "TotalWorkHoursLabel"
Me.TotalWorkHoursLabel.Location = New System.Drawing.Point(15, 327)
Me.TotalWorkHoursLabel.Size = New System.Drawing.Size(138, 16)
Me.TotalWorkHoursLabel.Visible=True
me.TotalWorkHoursLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.TotalWorkHoursLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.TotalWorkHoursLabel.Text = "Ώρες Εργασίας (Ολικό)"


Me.Regcode.Name = "Regcode"
Me.Regcode.Location = New System.Drawing.Point(323, 115)
Me.Regcode.Size = New System.Drawing.Size(139, 16)
Me.Regcode.Visible=True
me.Regcode.TabIndex = 1
me.Regcode.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Regcode.ReadOnly = True
Me.Regcode.TextAlign=HorizontalAlignment.Left


Me.RegCodeLabel.Name = "RegCodeLabel"
Me.RegCodeLabel.Location = New System.Drawing.Point(187, 115)
Me.RegCodeLabel.Size = New System.Drawing.Size(132, 16)
Me.RegCodeLabel.Visible=True
me.RegCodeLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.RegCodeLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.RegCodeLabel.Text = "Αρ. Άδειας Χρήσης"


Me.CmdRegister.Name = "CmdRegister"
Me.CmdRegister.Location = New System.Drawing.Point(484, 109)
Me.CmdRegister.Size = New System.Drawing.Size(31, 26)
Me.CmdRegister.Visible=True
me.CmdRegister.TabIndex = 0
me.CmdRegister.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.CmdRegister.Text = ""
Me.CmdRegister.forecolor = System.Drawing.ColorTranslator.FromOle(-2147483630)
Me.EmployeeLimit.Name = "EmployeeLimit"
Me.EmployeeLimit.Location = New System.Drawing.Point(323, 158)
Me.EmployeeLimit.Size = New System.Drawing.Size(139, 16)
Me.EmployeeLimit.Visible=True
me.EmployeeLimit.TabIndex = 3
me.EmployeeLimit.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.EmployeeLimit.ReadOnly = True
Me.EmployeeLimit.TextAlign=HorizontalAlignment.Left


Me.EmployeeLimitLabel.Name = "EmployeeLimitLabel"
Me.EmployeeLimitLabel.Location = New System.Drawing.Point(189, 158)
Me.EmployeeLimitLabel.Size = New System.Drawing.Size(130, 16)
Me.EmployeeLimitLabel.Visible=True
me.EmployeeLimitLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.EmployeeLimitLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.EmployeeLimitLabel.Text = "'Οριο Αριθμού Υπαλλήλων"


Me.Image14.Name = "Image14"
Me.Image14.Location = New System.Drawing.Point(11, 3)
Me.Image14.Size = New System.Drawing.Size(170, 273)
Me.Image14.Visible=True
Me.WarningLabel.Name = "WarningLabel"
Me.WarningLabel.Location = New System.Drawing.Point(189, 4)
Me.WarningLabel.Size = New System.Drawing.Size(317, 91)
Me.WarningLabel.Visible=True
me.WarningLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.WarningLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft
Me.WarningLabel.Text = "Προειδοποίηση: Το λογισμικό αυτό προστατεύετε από διεθνής νομοθεσίες και συνθήκες κατοχύρωσης πνευματικής ιδιοκτησίας. " & vbCrLf & "" & vbCrLf & "Μη εξουσιοδοτημένη χρήση, αναπαραγωγή, αντιγραφή η διανομή του λογισμικού η μέρος του λογισμικού αυτού θεωρείτε ποινικό αδίκημα και υπόκειται σε πρόστιμο η και φυλάκιση."


Me.CmdClearSortKeys.Name = "CmdClearSortKeys"
Me.CmdClearSortKeys.Location = New System.Drawing.Point(16, 357)
Me.CmdClearSortKeys.Size = New System.Drawing.Size(113, 38)
Me.CmdClearSortKeys.Visible=True
me.CmdClearSortKeys.TabIndex = 13
me.CmdClearSortKeys.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.CmdClearSortKeys.Text = "Clear Sort Keys"
Me.CmdClearSortKeys.forecolor = System.Drawing.ColorTranslator.FromOle(-2147483630)
Me.LblEval.Name = "LblEval"
Me.LblEval.Location = New System.Drawing.Point(191, 98)
Me.LblEval.Size = New System.Drawing.Size(316, 14)
Me.LblEval.Visible=False
me.LblEval.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.LblEval.TextAlign=System.Drawing.ContentAlignment.Middlecenter
Me.LblEval.Text = "** THIS IS AN EVALUATION VERSION**"


Me.CmdFixQueries.Name = "CmdFixQueries"
Me.CmdFixQueries.Location = New System.Drawing.Point(139, 357)
Me.CmdFixQueries.Size = New System.Drawing.Size(113, 38)
Me.CmdFixQueries.Visible=True
me.CmdFixQueries.TabIndex = 14
me.CmdFixQueries.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.CmdFixQueries.Text = "Create Views"
Me.CmdFixQueries.forecolor = System.Drawing.ColorTranslator.FromOle(-2147483630)
Me.CmdCheckPayrollItems.Name = "CmdCheckPayrollItems"
Me.CmdCheckPayrollItems.Location = New System.Drawing.Point(260, 357)
Me.CmdCheckPayrollItems.Size = New System.Drawing.Size(113, 38)
Me.CmdCheckPayrollItems.Visible=True
me.CmdCheckPayrollItems.TabIndex = 15
me.CmdCheckPayrollItems.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.CmdCheckPayrollItems.Text = "Check Payroll Items"
Me.CmdCheckPayrollItems.forecolor = System.Drawing.ColorTranslator.FromOle(-2147483630)
Me.CmdInstallNewDeployer.Name = "CmdInstallNewDeployer"
Me.CmdInstallNewDeployer.Location = New System.Drawing.Point(388, 357)
Me.CmdInstallNewDeployer.Size = New System.Drawing.Size(86, 38)
Me.CmdInstallNewDeployer.Visible=True
me.CmdInstallNewDeployer.TabIndex = 16
me.CmdInstallNewDeployer.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.CmdInstallNewDeployer.Text = "Install New Deployer"
Me.CmdInstallNewDeployer.forecolor = System.Drawing.ColorTranslator.FromOle(-2147483630)
Me.CmdstartLogging.Name = "CmdstartLogging"
Me.CmdstartLogging.Location = New System.Drawing.Point(483, 357)
Me.CmdstartLogging.Size = New System.Drawing.Size(86, 38)
Me.CmdstartLogging.Visible=True
me.CmdstartLogging.TabIndex = 17
me.CmdstartLogging.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.CmdstartLogging.Text = "Start Logging"
Me.CmdstartLogging.forecolor = System.Drawing.ColorTranslator.FromOle(-2147483630)
       
		
		Me.ErrProvider.ContainerControl = Me
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        
        
Me.controls.add(me.Serial)
Me.controls.add(me.SerialnoLabel)
Me.controls.add(me.Text10)
Me.controls.add(me.DatabaseLabel)
Me.controls.add(me.Text12)
Me.controls.add(me.Label13)
Me.controls.add(me.NumEmployees)
Me.controls.add(me.NumberOfEmployeesLabel)
Me.controls.add(me.Text17)
Me.controls.add(me.NumberPaychecksLabel)
Me.controls.add(me.Text0)
Me.controls.add(me.Label1)
Me.controls.add(me.LatestPaycheck)
Me.controls.add(me.LatestPacheckLabel)
Me.controls.add(me.EarliestPaycheck)
Me.controls.add(me.EarliestPaycheckLabel)
Me.controls.add(me.TotalWorkdays)
Me.controls.add(me.TotalWorkDaysLabel)
Me.controls.add(me.TotalHours)
Me.controls.add(me.TotalWorkHoursLabel)
Me.controls.add(me.Regcode)
Me.controls.add(me.RegCodeLabel)
Me.controls.add(me.CmdRegister)
Me.controls.add(me.EmployeeLimit)
Me.controls.add(me.EmployeeLimitLabel)
Me.controls.add(me.Image14)
Me.controls.add(me.WarningLabel)
Me.controls.add(me.CmdClearSortKeys)
Me.controls.add(me.LblEval)
Me.controls.add(me.CmdFixQueries)
Me.controls.add(me.CmdCheckPayrollItems)
Me.controls.add(me.CmdInstallNewDeployer)
Me.controls.add(me.CmdstartLogging)
        
        Me.Name = "FrmAbout"
        Me.Text = " Περί CGL Payroll…"
		Me.ClientSize = New System.Drawing.Size(602, 405)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	
	End Sub

    Friend WithEvents Serial As Textbox
Friend WithEvents SerialnoLabel As Label
Friend WithEvents Text10 As Textbox
Friend WithEvents DatabaseLabel As Label
Friend WithEvents Text12 As Textbox
Friend WithEvents Label13 As Label
Friend WithEvents NumEmployees As Textbox
Friend WithEvents NumberOfEmployeesLabel As Label
Friend WithEvents Text17 As Textbox
Friend WithEvents NumberPaychecksLabel As Label
Friend WithEvents Text0 As Textbox
Friend WithEvents Label1 As Label
Friend WithEvents LatestPaycheck As DateTimePicker
Friend WithEvents LatestPacheckLabel As Label
Friend WithEvents EarliestPaycheck As DateTimePicker
Friend WithEvents EarliestPaycheckLabel As Label
Friend WithEvents TotalWorkdays As Textbox
Friend WithEvents TotalWorkDaysLabel As Label
Friend WithEvents TotalHours As Textbox
Friend WithEvents TotalWorkHoursLabel As Label
Friend WithEvents Regcode As Textbox
Friend WithEvents RegCodeLabel As Label
Friend WithEvents CmdRegister As System.Windows.Forms.Button
Friend WithEvents EmployeeLimit As Textbox
Friend WithEvents EmployeeLimitLabel As Label
Friend WithEvents Image14 As System.Windows.Forms.PictureBox
Friend WithEvents WarningLabel As Label
Friend WithEvents CmdClearSortKeys As System.Windows.Forms.Button
Friend WithEvents LblEval As Label
Friend WithEvents CmdFixQueries As System.Windows.Forms.Button
Friend WithEvents CmdCheckPayrollItems As System.Windows.Forms.Button
Friend WithEvents CmdInstallNewDeployer As System.Windows.Forms.Button
Friend WithEvents CmdstartLogging As System.Windows.Forms.Button

    Friend WithEvents ErrProvider As System.Windows.Forms.ErrorProvider
End Class
