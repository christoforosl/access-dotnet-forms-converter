'
' Form converted from MSAccess database using AccessDotNetConverter on Sunday, June 23, 2013
' https://code.google.com/p/msaccess-subversion-control
' 
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListEmployee
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
		
		 Me.DataListCount = New Textbox
Me.NoofemployeesLabel = New Label
Me.Payfrequencyid = New ConvertedMSAccessControls.AccessCombo
Me.PayFrequencyIDLabel = New Label
Me.EmployeeTypeID = New ConvertedMSAccessControls.AccessCombo
Me.EmployeetypeLabel = New Label
Me.Rankid = New ConvertedMSAccessControls.AccessCombo
Me.RankLabel = New Label
Me.Departmentid = New ConvertedMSAccessControls.AccessCombo
Me.DepartmentLabel = New Label
Me.Unionid = New ConvertedMSAccessControls.AccessCombo
Me.UnionLabel = New Label
Me.Professionid = New ConvertedMSAccessControls.AccessCombo
Me.ProfessionLabel = New Label
Me.CboActive = New ConvertedMSAccessControls.AccessCombo
Me.EmplLeaveTypeId = New ConvertedMSAccessControls.AccessCombo
Me.EmployeeAnnualLeaveTypeShortLabel = New Label
Me.EmplAccTypeId = New ConvertedMSAccessControls.AccessCombo
Me.EmplAccTypeShortLabel = New Label
Me.EmploymentStatusId = New ConvertedMSAccessControls.AccessCombo
Me.EmploymentStatusShortLabel = New Label
Me.SocinsCategoryid = New ConvertedMSAccessControls.AccessCombo
Me.Label30 = New Label

        Me.SuspendLayout()
		
		Me.ErrProvider = New System.Windows.Forms.ErrorProvider()
 
	   'do tab pages here
        
Me.DataListCount.Name = "DataListCount"
Me.DataListCount.Location = New System.Drawing.Point(770, 44)
Me.DataListCount.Size = New System.Drawing.Size(64, 15)
Me.DataListCount.Visible=True
me.DataListCount.TabIndex = 8
me.DataListCount.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.DataListCount.ReadOnly = True
me.DataListCount.backcolor =me.backcolor
Me.DataListCount.TextAlign=HorizontalAlignment.Left


Me.NoofemployeesLabel.Name = "NoofemployeesLabel"
Me.NoofemployeesLabel.Location = New System.Drawing.Point(657, 44)
Me.NoofemployeesLabel.Size = New System.Drawing.Size(113, 15)
Me.NoofemployeesLabel.Visible=True
me.NoofemployeesLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.NoofemployeesLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.NoofemployeesLabel.Text = "Αριθμός Υπαλλήλων:"


Me.Payfrequencyid.Name = "Payfrequencyid"
Me.Payfrequencyid.Location = New System.Drawing.Point(137, 5)
Me.Payfrequencyid.Size = New System.Drawing.Size(114, 16)
Me.Payfrequencyid.Visible=True
me.Payfrequencyid.TabIndex = 1
me.Payfrequencyid.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Payfrequencyid.RowSourceType = "Table/Query"
me.Payfrequencyid.RowSource = "vPickListPayFrequency"

Me.PayFrequencyIDLabel.Name = "PayFrequencyIDLabel"
Me.PayFrequencyIDLabel.Location = New System.Drawing.Point(4, 5)
Me.PayFrequencyIDLabel.Size = New System.Drawing.Size(129, 16)
Me.PayFrequencyIDLabel.Visible=True
me.PayFrequencyIDLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.PayFrequencyIDLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.PayFrequencyIDLabel.Text = "Συχνότητα Πληρωμής"


Me.EmployeeTypeID.Name = "EmployeeTypeID"
Me.EmployeeTypeID.Location = New System.Drawing.Point(137, 23)
Me.EmployeeTypeID.Size = New System.Drawing.Size(114, 15)
Me.EmployeeTypeID.Visible=True
me.EmployeeTypeID.TabIndex = 4
me.EmployeeTypeID.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.EmployeeTypeID.RowSourceType = "Table/Query"
me.EmployeeTypeID.RowSource = "vPickListEmployeeType"

Me.EmployeetypeLabel.Name = "EmployeetypeLabel"
Me.EmployeetypeLabel.Location = New System.Drawing.Point(22, 23)
Me.EmployeetypeLabel.Size = New System.Drawing.Size(111, 15)
Me.EmployeetypeLabel.Visible=True
me.EmployeetypeLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.EmployeetypeLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.EmployeetypeLabel.Text = "Κατηγορία/Ομάδα"


Me.Rankid.Name = "Rankid"
Me.Rankid.Location = New System.Drawing.Point(328, 44)
Me.Rankid.Size = New System.Drawing.Size(114, 16)
Me.Rankid.Visible=True
me.Rankid.TabIndex = 6
me.Rankid.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Rankid.RowSourceType = "Table/Query"
me.Rankid.RowSource = "vPickListEmployeeRank"

Me.RankLabel.Name = "RankLabel"
Me.RankLabel.Location = New System.Drawing.Point(265, 44)
Me.RankLabel.Size = New System.Drawing.Size(58, 16)
Me.RankLabel.Visible=True
me.RankLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.RankLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.RankLabel.Text = "Βαθμός"


Me.Departmentid.Name = "Departmentid"
Me.Departmentid.Location = New System.Drawing.Point(328, 23)
Me.Departmentid.Size = New System.Drawing.Size(114, 15)
Me.Departmentid.Visible=True
me.Departmentid.TabIndex = 5
me.Departmentid.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Departmentid.RowSourceType = "Table/Query"
me.Departmentid.RowSource = "vPickListDepartments"

Me.DepartmentLabel.Name = "DepartmentLabel"
Me.DepartmentLabel.Location = New System.Drawing.Point(258, 23)
Me.DepartmentLabel.Size = New System.Drawing.Size(64, 15)
Me.DepartmentLabel.Visible=True
me.DepartmentLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.DepartmentLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.DepartmentLabel.Text = "Τμήμα"


Me.Unionid.Name = "Unionid"
Me.Unionid.Location = New System.Drawing.Point(725, 23)
Me.Unionid.Size = New System.Drawing.Size(114, 16)
Me.Unionid.Visible=True
me.Unionid.TabIndex = 3
me.Unionid.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Unionid.RowSourceType = "Table/Query"
me.Unionid.RowSource = "vPickListUnionEmployee"

Me.UnionLabel.Name = "UnionLabel"
Me.UnionLabel.Location = New System.Drawing.Point(661, 23)
Me.UnionLabel.Size = New System.Drawing.Size(58, 16)
Me.UnionLabel.Visible=True
me.UnionLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.UnionLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.UnionLabel.Text = "Συντεχνία"


Me.Professionid.Name = "Professionid"
Me.Professionid.Location = New System.Drawing.Point(328, 5)
Me.Professionid.Size = New System.Drawing.Size(114, 16)
Me.Professionid.Visible=True
me.Professionid.TabIndex = 2
me.Professionid.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Professionid.RowSourceType = "Table/Query"
me.Professionid.RowSource = "vPickListEmployeeProfession"

Me.ProfessionLabel.Name = "ProfessionLabel"
Me.ProfessionLabel.Location = New System.Drawing.Point(259, 5)
Me.ProfessionLabel.Size = New System.Drawing.Size(64, 16)
Me.ProfessionLabel.Visible=True
me.ProfessionLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.ProfessionLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.ProfessionLabel.Text = "Επάγγελμα"


Me.CboActive.Name = "CboActive"
Me.CboActive.Location = New System.Drawing.Point(137, 44)
Me.CboActive.Size = New System.Drawing.Size(114, 16)
Me.CboActive.Visible=True
me.CboActive.TabIndex = 0
me.CboActive.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.CboActive.RowSourceType = "Table/Query"
me.CboActive.RowSource = "vPickListActive"

Me.EmplLeaveTypeId.Name = "EmplLeaveTypeId"
Me.EmplLeaveTypeId.Location = New System.Drawing.Point(541, 23)
Me.EmplLeaveTypeId.Size = New System.Drawing.Size(114, 16)
Me.EmplLeaveTypeId.Visible=True
me.EmplLeaveTypeId.TabIndex = 9
me.EmplLeaveTypeId.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.EmplLeaveTypeId.RowSourceType = "Table/Query"
me.EmplLeaveTypeId.RowSource = "EmployeeAnnualLeaveType"

Me.EmployeeAnnualLeaveTypeShortLabel.Name = "EmployeeAnnualLeaveTypeShortLabel"
Me.EmployeeAnnualLeaveTypeShortLabel.Location = New System.Drawing.Point(466, 23)
Me.EmployeeAnnualLeaveTypeShortLabel.Size = New System.Drawing.Size(69, 16)
Me.EmployeeAnnualLeaveTypeShortLabel.Visible=True
me.EmployeeAnnualLeaveTypeShortLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.EmployeeAnnualLeaveTypeShortLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.EmployeeAnnualLeaveTypeShortLabel.Text = "Τύπος Άδειας"


Me.EmplAccTypeId.Name = "EmplAccTypeId"
Me.EmplAccTypeId.Location = New System.Drawing.Point(541, 44)
Me.EmplAccTypeId.Size = New System.Drawing.Size(114, 16)
Me.EmplAccTypeId.Visible=True
me.EmplAccTypeId.TabIndex = 10
me.EmplAccTypeId.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.EmplAccTypeId.RowSourceType = "Table/Query"
me.EmplAccTypeId.RowSource = "vPickListEmplAccType"

Me.EmplAccTypeShortLabel.Name = "EmplAccTypeShortLabel"
Me.EmplAccTypeShortLabel.Location = New System.Drawing.Point(442, 44)
Me.EmplAccTypeShortLabel.Size = New System.Drawing.Size(93, 16)
Me.EmplAccTypeShortLabel.Visible=True
me.EmplAccTypeShortLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.EmplAccTypeShortLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.EmplAccTypeShortLabel.Text = "Τύπος Λογ. Συνδ."


Me.EmploymentStatusId.Name = "EmploymentStatusId"
Me.EmploymentStatusId.Location = New System.Drawing.Point(541, 4)
Me.EmploymentStatusId.Size = New System.Drawing.Size(114, 16)
Me.EmploymentStatusId.Visible=True
me.EmploymentStatusId.TabIndex = 11
me.EmploymentStatusId.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.EmploymentStatusId.RowSourceType = "Table/Query"
me.EmploymentStatusId.RowSource = "vPickListEmploymentStatus"

Me.EmploymentStatusShortLabel.Name = "EmploymentStatusShortLabel"
Me.EmploymentStatusShortLabel.Location = New System.Drawing.Point(464, 4)
Me.EmploymentStatusShortLabel.Size = New System.Drawing.Size(71, 16)
Me.EmploymentStatusShortLabel.Visible=True
me.EmploymentStatusShortLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.EmploymentStatusShortLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.EmploymentStatusShortLabel.Text = "Εργοδότηση"


Me.SocinsCategoryid.Name = "SocinsCategoryid"
Me.SocinsCategoryid.Location = New System.Drawing.Point(725, 2)
Me.SocinsCategoryid.Size = New System.Drawing.Size(114, 16)
Me.SocinsCategoryid.Visible=True
me.SocinsCategoryid.TabIndex = 12
me.SocinsCategoryid.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.SocinsCategoryid.RowSourceType = "Table/Query"
me.SocinsCategoryid.RowSource = "EmployeeSocialInsuranceType"

Me.Label30.Name = "Label30"
Me.Label30.Location = New System.Drawing.Point(610, 2)
Me.Label30.Size = New System.Drawing.Size(109, 16)
Me.Label30.Visible=True
me.Label30.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.Label30.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.Label30.Text = "Κοιν. Ασφ."


       
		
		Me.ErrProvider.ContainerControl = Me
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        
        
Me.controls.add(me.DataListCount)
Me.controls.add(me.NoofemployeesLabel)
Me.controls.add(me.Payfrequencyid)
Me.controls.add(me.PayFrequencyIDLabel)
Me.controls.add(me.EmployeeTypeID)
Me.controls.add(me.EmployeetypeLabel)
Me.controls.add(me.Rankid)
Me.controls.add(me.RankLabel)
Me.controls.add(me.Departmentid)
Me.controls.add(me.DepartmentLabel)
Me.controls.add(me.Unionid)
Me.controls.add(me.UnionLabel)
Me.controls.add(me.Professionid)
Me.controls.add(me.ProfessionLabel)
Me.controls.add(me.CboActive)
Me.controls.add(me.EmplLeaveTypeId)
Me.controls.add(me.EmployeeAnnualLeaveTypeShortLabel)
Me.controls.add(me.EmplAccTypeId)
Me.controls.add(me.EmplAccTypeShortLabel)
Me.controls.add(me.EmploymentStatusId)
Me.controls.add(me.EmploymentStatusShortLabel)
Me.controls.add(me.SocinsCategoryid)
Me.controls.add(me.Label30)
        
        Me.Name = "FrmListEmployee"
        Me.Text = " Λίστα Υπαλλήλων"
		Me.ClientSize = New System.Drawing.Size(1347, 597)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	
	End Sub

    Friend WithEvents DataListCount As Textbox
Friend WithEvents NoofemployeesLabel As Label
Friend WithEvents Payfrequencyid As ConvertedMSAccessControls.AccessCombo
Friend WithEvents PayFrequencyIDLabel As Label
Friend WithEvents EmployeeTypeID As ConvertedMSAccessControls.AccessCombo
Friend WithEvents EmployeetypeLabel As Label
Friend WithEvents Rankid As ConvertedMSAccessControls.AccessCombo
Friend WithEvents RankLabel As Label
Friend WithEvents Departmentid As ConvertedMSAccessControls.AccessCombo
Friend WithEvents DepartmentLabel As Label
Friend WithEvents Unionid As ConvertedMSAccessControls.AccessCombo
Friend WithEvents UnionLabel As Label
Friend WithEvents Professionid As ConvertedMSAccessControls.AccessCombo
Friend WithEvents ProfessionLabel As Label
Friend WithEvents CboActive As ConvertedMSAccessControls.AccessCombo
Friend WithEvents EmplLeaveTypeId As ConvertedMSAccessControls.AccessCombo
Friend WithEvents EmployeeAnnualLeaveTypeShortLabel As Label
Friend WithEvents EmplAccTypeId As ConvertedMSAccessControls.AccessCombo
Friend WithEvents EmplAccTypeShortLabel As Label
Friend WithEvents EmploymentStatusId As ConvertedMSAccessControls.AccessCombo
Friend WithEvents EmploymentStatusShortLabel As Label
Friend WithEvents SocinsCategoryid As ConvertedMSAccessControls.AccessCombo
Friend WithEvents Label30 As Label

    Friend WithEvents ErrProvider As System.Windows.Forms.ErrorProvider
End Class
