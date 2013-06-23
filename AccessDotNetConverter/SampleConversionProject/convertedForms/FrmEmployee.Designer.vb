'
' Form converted from MSAccess database using AccessDotNetConverter on Sunday, June 23, 2013
' https://code.google.com/p/msaccess-subversion-control
' 
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmployee
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
		
		 Me.TbEmployee = New System.Windows.Forms.TabControl

Me.TbEmployee.SuspendLayout()
Me.PgEmployeeInfo = New System.Windows.Forms.TabPage
Me.PgEmployeeInfo.SuspendLayout()
Me.Salutation = New ConvertedMSAccessControls.AccessCombo
Me.FirstName = New Textbox
Me.FirstNameLabel = New Label
Me.MiddleName = New Textbox
Me.MiddleNameLabel = New Label
Me.LastName = New Textbox
Me.LastNameLabel = New Label
Me.QuickBooksName = New Textbox
Me.QuickBooksNameLabel = New Label
Me.EmployeeAddressAddr1 = New Textbox
Me.Addr1Label = New Label
Me.EmployeeAddressAddr2 = New Textbox
Me.EmployeeAddressCity = New Textbox
Me.CityLabel = New Label
Me.EmployeeAddressState = New Textbox
Me.StateLabel = New Label
Me.EmployeeAddressPostalCode = New Textbox
Me.PostalCodeLabel = New Label
Me.EmployeeAddressCountry = New Textbox
Me.CountryLabel = New Label
Me.Telephone = New Textbox
Me.PhoneLabel = New Label
Me.MobilePhone = New Textbox
Me.MobilePhoneLabel = New Label
Me.Telephone2 = New Textbox
Me.Telephone2Label = New Label
Me.Email = New Textbox
Me.EmailLabel = New Label
Me.Genderid = New ConvertedMSAccessControls.AccessCombo
Me.GenderidLabel = New Label
Me.HiredDate = New DateTimePicker
Me.HiredDateLabel = New Label
Me.CmdCalHireddate = New System.Windows.Forms.Button
Me.SocialInsuranceNumber = New Textbox
Me.SocialInsuranceNumberLabel = New Label
Me.Cyprusidnumber = New Textbox
Me.CyprusidnumberLabel = New Label
Me.PayFrequencyID = New ConvertedMSAccessControls.AccessCombo
Me.PayFrequencyIDLabel = New Label
Me.Dateofbirth = New Textbox
Me.DateofbirthLabel = New Label
Me.CmdCalDateofbirth = New System.Windows.Forms.Button
Me.Placeofbirth = New Textbox
Me.PlaceofbirthLabel = New Label
Me.Maritalstatus = New ConvertedMSAccessControls.AccessCombo
Me.MaritalstatusLabel = New Label
Me.Professionid = New ConvertedMSAccessControls.AccessCombo
Me.ProfessionLabel = New Label
Me.AlienIDNumber = New Textbox
Me.AlienIDNumberLabel = New Label
Me.PassportNumber = New Textbox
Me.PassportNumberLabel = New Label
Me.SocinsCategoryid = New ConvertedMSAccessControls.AccessCombo
Me.SocinsCategoryLabel = New Label
Me.Ssicommunityid = New ConvertedMSAccessControls.AccessCombo
Me.SsicommunityidLabel = New Label
Me.DriverLicenceNo = New Textbox
Me.DriverLicenceNoLabel = New Label
Me.ITaxIdNumber = New Textbox
Me.ITaxIdNumberLabel = New Label
Me.CSSId = New ConvertedMSAccessControls.AccessCombo
Me.CSSIdLabel = New Label
Me.CmdChangeHireDate = New System.Windows.Forms.Button
Me.PgPayroll = New System.Windows.Forms.TabPage
Me.PgPayroll.SuspendLayout()
Me.ColaAdjusted = New System.Windows.Forms.Checkbox
Me.ColaadjustedLabel = New Label
Me.RegularDaysHoursLabel = New Label
Me.CmdChangeSalaries = New System.Windows.Forms.Button
Me.CompanyPaidTaxesLabel = New Label
Me.IncreaseMonth = New ConvertedMSAccessControls.AccessCombo
Me.IncreaseMonthLabel = New Label
Me.HourlySalaryCalcMethodID = New ConvertedMSAccessControls.AccessCombo
Me.HourSalaryCalculationMethodLabel = New Label
Me.FixedHoursPerPeriod = New Textbox
Me.FixedHoursPerPeriodLabel = New Label
Me.DayLabel1 = New Textbox
Me.Timein1 = New Textbox
Me.Timeout1 = New Textbox
Me.RegularHours1 = New Textbox
Me.DayLabel2 = New Textbox
Me.Timein2 = New Textbox
Me.Timeout2 = New Textbox
Me.RegularHours2 = New Textbox
Me.DayLabel3 = New Textbox
Me.Timein3 = New Textbox
Me.Timeout3 = New Textbox
Me.RegularHours3 = New Textbox
Me.EmployeePaidTaxesLabel = New Label
Me.CmdDefaults = New System.Windows.Forms.Button
Me.DayLabel4 = New Textbox
Me.Timein4 = New Textbox
Me.Timeout4 = New Textbox
Me.RegularHours4 = New Textbox
Me.DayLabel5 = New Textbox
Me.Timein5 = New Textbox
Me.Timeout5 = New Textbox
Me.RegularHours5 = New Textbox
Me.DayLabel6 = New Textbox
Me.Timein6 = New Textbox
Me.Timeout6 = New Textbox
Me.Box125 = New System.Windows.Forms.GroupBox
Me.RegularHours6 = New Textbox
Me.DayLabel7 = New Textbox
Me.Timein7 = New Textbox
Me.Timeout7 = New Textbox
Me.RegularHours7 = New Textbox
Me.TxtTotHours = New Textbox
Me.EmployeeTypeID = New ConvertedMSAccessControls.AccessCombo
Me.EmployeetypeLabel = New Label
Me.ChildEmployeeSalaryHistory = New ConvertedMSAccessControls.AccessListBox
Me.CmdDeleteSalary = New System.Windows.Forms.Button
Me.PgOtherInfo = New System.Windows.Forms.TabPage
Me.PgOtherInfo.SuspendLayout()
Me.ChkisSystemUser = New System.Windows.Forms.Checkbox
Me.SystemUserLabel = New Label
Me.Username = New Textbox
Me.UsernameLabel = New Label
Me.DaysLabel = New Label
Me.ActiveLabelHelp = New Label
Me.Box163 = New System.Windows.Forms.GroupBox
Me.Password = New Textbox
Me.PasswordLabel = New Label
Me.SecurityLevelId = New ConvertedMSAccessControls.AccessCombo
Me.RightsLabel = New Label
Me.PayslipLanguage = New ConvertedMSAccessControls.AccessCombo
Me.PayslipLanguageLabel = New Label
Me.HolidaysPaidAfterDays = New Textbox
Me.ChkHolidaysPaid = New System.Windows.Forms.Checkbox
Me.HolidaysPaidLabel = New Label
Me.ChkIsActive = New System.Windows.Forms.Checkbox
Me.IsActiveLabel = New Label
Me.Unionid = New ConvertedMSAccessControls.AccessCombo
Me.UnionLabel = New Label
Me.Notes = New Textbox
Me.NotesLabel = New Label
Me.DefaultServiceItemid = New ConvertedMSAccessControls.AccessCombo
Me.DefaultServiceItemidLabel = New Label
Me.Defaultprojectid = New ConvertedMSAccessControls.AccessCombo
Me.DefaultprojectidLabel = New Label
Me.DefaultCompany = New ConvertedMSAccessControls.AccessCombo
Me.DefaultCompanyLabel = New Label
Me.Tab13th = New System.Windows.Forms.TabPage
Me.Tab13th.SuspendLayout()
Me.ReleaseddateHelpLabel = New Label
Me.AvailableVacationDays = New Textbox
Me.AvailableSickDays = New Textbox
Me.ReleasedDate = New DateTimePicker
Me.LastworkdateLabel = New Label
Me.TerminationReasonId = New ConvertedMSAccessControls.AccessCombo
Me.TerminationReasonLabel = New Label
Me.TermOptionPayExtraSalaries = New System.Windows.Forms.Checkbox
Me.ChkPayExtraSalariesLabel = New Label
Me.TermOptionPaySickDaysOff = New System.Windows.Forms.Checkbox
Me.TermpaydaysoffsickLabel = New Label
Me.Frame244 = New System.Windows.Forms.GroupBox
Me.TerminationLabel = New Label
Me.PaidPeriods = New Textbox
Me.PaidPeriodsLabel = New Label
Me.PermanentTerninaltionOnlyLabel = New Label
Me.RegularPeriods = New Textbox
Me.YearperiodsLabel = New Label
Me.Lastpaydate = New Textbox
Me.LastpaydateLabel = New Label
Me.TxtUsedSickDays = New Textbox
Me.AvailableLabel = New Label
Me.TakenLabel = New Label
Me.EarnedVacDaysleftLabel = New Label
Me.TxtUsedVacationDays = New Textbox
Me.TxtLeftSickDays = New Textbox
Me.TxtLeftVacationDays = New Textbox
Me.TxtTotalFinalExtraPay = New Textbox
Me.TotalFinalExtraPayLabel = New Label
Me.TxtEarnedSickDays = New Textbox
Me.EarnedtodateLabel = New Label
Me.TxtEarnedVacationDays = New Textbox
Me.AvailableSickDaysLabel = New Label
Me.AvailableVacationHoursLabel = New Label
Me.Paidportion = New Textbox
Me.PaidportionLabel = New Label
Me.CmdNextYear = New System.Windows.Forms.Button
Me.CmdPreviousYear = New System.Windows.Forms.Button
Me.PayyearLabel = New Label
Me.Filteryear = New Textbox
Me.Frame335 = New System.Windows.Forms.GroupBox
Me.VacationdaysStmtLabel = New Label
Me.LeftLabel1 = New Label
Me.TxtLeftSickDaysPrev = New Textbox
Me.TxtLeftVacationDaysPrev = New Textbox
Me.TransferredDaysoff = New Textbox
Me.TransferredDaysoffLabel = New Label
Me.EmplLeaveTypeId = New ConvertedMSAccessControls.AccessCombo
Me.EmployeeAnnualLeaveTypeLabel = New Label
Me.PgAccounting = New System.Windows.Forms.TabPage
Me.PgAccounting.SuspendLayout()
Me.EmplAccTypeId = New ConvertedMSAccessControls.AccessCombo
Me.EmplAccTypeLabel = New Label
Me.PaymentAccountIDHelpLabel = New Label
Me.PaymentAccountID = New ConvertedMSAccessControls.AccessCombo
Me.PaymentAccountIDLabel = New Label
Me.Frame309 = New System.Windows.Forms.GroupBox
Me.EmplOverheadLabel = New Label
Me.PayMethodID = New ConvertedMSAccessControls.AccessCombo
Me.PaymethodLabel = New Label
Me.OhEmployeeCostHelpLabel = New Label
Me.OhHiringCostHelpLabel = New Label
Me.BankAccNumber = New Textbox
Me.BankAccNumberLabel = New Label
Me.BankAccountIBANCode = New Textbox
Me.BankAccountIBANCodeLabel = New Label
Me.BankId = New ConvertedMSAccessControls.AccessCombo
Me.BankIdLabel = New Label
Me.EmplAccountBankSWIFTCode = New Textbox
Me.BankSWIFTCodeLabel = New Label
Me.BankBeneficiaryName = New Textbox
Me.BankBeneficiaryNameLabel = New Label
Me.BankBeneficiaryIdCode = New Textbox
Me.BankBeneficiaryIdCodeLabel = New Label
Me.NoPayForExtraHours = New System.Windows.Forms.Checkbox
Me.NoPayForExtraHoursLabel = New Label
Me.BankBenNmHelp = New Label
Me.NoDeductionForLessHours = New System.Windows.Forms.Checkbox
Me.NoDeductionForLessHoursLabel = New Label
Me.OhHiringCost = New Textbox
Me.EmplOhHiringCosts = New Label
Me.OhEmployeeCost = New Textbox
Me.EmplOhYearlyCosts = New Label
Me.HrinfoLabel = New System.Windows.Forms.TabPage
Me.HrinfoLabel.SuspendLayout()
Me.Rankid = New ConvertedMSAccessControls.AccessCombo
Me.RankLabel = New Label
Me.Departmentid = New ConvertedMSAccessControls.AccessCombo
Me.DepartmentLabel = New Label
Me.ManagerEmplId = New ConvertedMSAccessControls.AccessCombo
Me.ManagerEmplIdLabel = New Label
Me.ProbationEndDate = New DateTimePicker
Me.ProbationEndDateLabel = New Label
Me.EmploymentStatusId = New ConvertedMSAccessControls.AccessCombo
Me.EmploymentStatusLabel = New Label
Me.ForeignIdNumber = New Textbox
Me.ForeignIdNumberLabel = New Label
Me.Spoucename = New Textbox
Me.SpoucenameLabel = New Label
Me.WorkDescription = New Textbox
Me.WorkDescriptionLabel = New Label
Me.HbfileDescription1 = New Textbox
Me.Label413 = New Label
Me.HbfileDescription2 = New Textbox
Me.Label415 = New Label
Me.HbfileDescription3 = New Textbox
Me.Label417 = New Label
Me.Companyid = New Textbox
Me.EmployeeNo = New Textbox
Me.EmployeeNoLabel = New Label
Me.Createuser = New Textbox
Me.Updateuser = New Textbox
Me.CmdDelete = New System.Windows.Forms.Button
Me.CmdReviewReport = New System.Windows.Forms.Button
Me.CmdPrintSocIns = New System.Windows.Forms.Button
Me.CmdSave = New System.Windows.Forms.Button
Me.CmdClose = New System.Windows.Forms.Button
Me.CmdIncomeTax = New System.Windows.Forms.Button
Me.Employeeid = New Textbox
Me.Createdate = New Textbox
Me.CreatedateShortLabel = New Label
Me.Updatedate = New Textbox
Me.UpdatedShortLabel = New Label
Me.CmdNext = New System.Windows.Forms.Button
Me.CmdPrev = New System.Windows.Forms.Button
Me.CmdCopy = New System.Windows.Forms.Button

        Me.SuspendLayout()
		
		Me.ErrProvider = New System.Windows.Forms.ErrorProvider()
 
	   'do tab pages here
        
Me.TbEmployee.Name = "TbEmployee"
Me.TbEmployee.Location = New System.Drawing.Point(0, 6)
Me.TbEmployee.Size = New System.Drawing.Size(804, 390)
Me.TbEmployee.Visible=True
me.TbEmployee.TabIndex = 0
me.TbEmployee.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.PgEmployeeInfo.Name = "PgEmployeeInfo"
Me.PgEmployeeInfo.Location = New System.Drawing.Point(9, 33)
Me.PgEmployeeInfo.Size = New System.Drawing.Size(786, 354)
Me.PgEmployeeInfo.Visible=True
Me.PgEmployeeInfo.Text = "General"

Me.Salutation.Name = "Salutation"
Me.Salutation.Location = New System.Drawing.Point(176, 22)
Me.Salutation.Size = New System.Drawing.Size(49, 16)
Me.Salutation.Visible=True
me.Salutation.TabIndex = 0
me.Salutation.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Salutation.RowSourceType = "Value List"
me.Salutation.RowSource = "Koς;Κα"

Me.FirstName.Name = "FirstName"
Me.FirstName.Location = New System.Drawing.Point(229, 22)
Me.FirstName.Size = New System.Drawing.Size(127, 16)
Me.FirstName.Visible=True
me.FirstName.TabIndex = 1
me.FirstName.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.FirstName.TextAlign=HorizontalAlignment.Left


Me.FirstNameLabel.Name = "FirstNameLabel"
Me.FirstNameLabel.Location = New System.Drawing.Point(49, 22)
Me.FirstNameLabel.Size = New System.Drawing.Size(120, 16)
Me.FirstNameLabel.Visible=True
me.FirstNameLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.FirstNameLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.FirstNameLabel.Text = "First Name"


Me.MiddleName.Name = "MiddleName"
Me.MiddleName.Location = New System.Drawing.Point(175, 43)
Me.MiddleName.Size = New System.Drawing.Size(37, 16)
Me.MiddleName.Visible=True
me.MiddleName.TabIndex = 2
me.MiddleName.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.MiddleName.TextAlign=HorizontalAlignment.Left


Me.MiddleNameLabel.Name = "MiddleNameLabel"
Me.MiddleNameLabel.Location = New System.Drawing.Point(49, 43)
Me.MiddleNameLabel.Size = New System.Drawing.Size(120, 16)
Me.MiddleNameLabel.Visible=True
me.MiddleNameLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.MiddleNameLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.MiddleNameLabel.Text = "Middle Name"


Me.LastName.Name = "LastName"
Me.LastName.Location = New System.Drawing.Point(175, 64)
Me.LastName.Size = New System.Drawing.Size(181, 16)
Me.LastName.Visible=True
me.LastName.TabIndex = 3
me.LastName.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.LastName.TextAlign=HorizontalAlignment.Left


Me.LastNameLabel.Name = "LastNameLabel"
Me.LastNameLabel.Location = New System.Drawing.Point(49, 64)
Me.LastNameLabel.Size = New System.Drawing.Size(120, 16)
Me.LastNameLabel.Visible=True
me.LastNameLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.LastNameLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.LastNameLabel.Text = "Last name"


Me.QuickBooksName.Name = "QuickBooksName"
Me.QuickBooksName.Location = New System.Drawing.Point(175, 84)
Me.QuickBooksName.Size = New System.Drawing.Size(181, 16)
Me.QuickBooksName.Visible=True
me.QuickBooksName.TabIndex = 4
me.QuickBooksName.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.QuickBooksName.TextAlign=HorizontalAlignment.Left


Me.QuickBooksNameLabel.Name = "QuickBooksNameLabel"
Me.QuickBooksNameLabel.Location = New System.Drawing.Point(20, 84)
Me.QuickBooksNameLabel.Size = New System.Drawing.Size(149, 16)
Me.QuickBooksNameLabel.Visible=True
me.QuickBooksNameLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.QuickBooksNameLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.QuickBooksNameLabel.Text = "Accounting System Code"


Me.EmployeeAddressAddr1.Name = "EmployeeAddressAddr1"
Me.EmployeeAddressAddr1.Location = New System.Drawing.Point(175, 105)
Me.EmployeeAddressAddr1.Size = New System.Drawing.Size(181, 16)
Me.EmployeeAddressAddr1.Visible=True
me.EmployeeAddressAddr1.TabIndex = 5
me.EmployeeAddressAddr1.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.EmployeeAddressAddr1.TextAlign=HorizontalAlignment.Left


Me.Addr1Label.Name = "Addr1Label"
Me.Addr1Label.Location = New System.Drawing.Point(49, 105)
Me.Addr1Label.Size = New System.Drawing.Size(120, 16)
Me.Addr1Label.Visible=True
me.Addr1Label.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.Addr1Label.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.Addr1Label.Text = "Address"


Me.EmployeeAddressAddr2.Name = "EmployeeAddressAddr2"
Me.EmployeeAddressAddr2.Location = New System.Drawing.Point(175, 126)
Me.EmployeeAddressAddr2.Size = New System.Drawing.Size(181, 16)
Me.EmployeeAddressAddr2.Visible=True
me.EmployeeAddressAddr2.TabIndex = 6
me.EmployeeAddressAddr2.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.EmployeeAddressAddr2.TextAlign=HorizontalAlignment.Left


Me.EmployeeAddressCity.Name = "EmployeeAddressCity"
Me.EmployeeAddressCity.Location = New System.Drawing.Point(175, 147)
Me.EmployeeAddressCity.Size = New System.Drawing.Size(181, 16)
Me.EmployeeAddressCity.Visible=True
me.EmployeeAddressCity.TabIndex = 7
me.EmployeeAddressCity.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.EmployeeAddressCity.TextAlign=HorizontalAlignment.Left


Me.CityLabel.Name = "CityLabel"
Me.CityLabel.Location = New System.Drawing.Point(49, 147)
Me.CityLabel.Size = New System.Drawing.Size(120, 16)
Me.CityLabel.Visible=True
me.CityLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.CityLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.CityLabel.Text = "Town/Village/Parish"


Me.EmployeeAddressState.Name = "EmployeeAddressState"
Me.EmployeeAddressState.Location = New System.Drawing.Point(175, 168)
Me.EmployeeAddressState.Size = New System.Drawing.Size(181, 16)
Me.EmployeeAddressState.Visible=True
me.EmployeeAddressState.TabIndex = 8
me.EmployeeAddressState.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.EmployeeAddressState.TextAlign=HorizontalAlignment.Left


Me.StateLabel.Name = "StateLabel"
Me.StateLabel.Location = New System.Drawing.Point(49, 168)
Me.StateLabel.Size = New System.Drawing.Size(120, 16)
Me.StateLabel.Visible=True
me.StateLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.StateLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.StateLabel.Text = "State/Province"


Me.EmployeeAddressPostalCode.Name = "EmployeeAddressPostalCode"
Me.EmployeeAddressPostalCode.Location = New System.Drawing.Point(175, 188)
Me.EmployeeAddressPostalCode.Size = New System.Drawing.Size(181, 16)
Me.EmployeeAddressPostalCode.Visible=True
me.EmployeeAddressPostalCode.TabIndex = 9
me.EmployeeAddressPostalCode.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.EmployeeAddressPostalCode.TextAlign=HorizontalAlignment.Left


Me.PostalCodeLabel.Name = "PostalCodeLabel"
Me.PostalCodeLabel.Location = New System.Drawing.Point(49, 188)
Me.PostalCodeLabel.Size = New System.Drawing.Size(120, 16)
Me.PostalCodeLabel.Visible=True
me.PostalCodeLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.PostalCodeLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.PostalCodeLabel.Text = "Postal Code"


Me.EmployeeAddressCountry.Name = "EmployeeAddressCountry"
Me.EmployeeAddressCountry.Location = New System.Drawing.Point(175, 209)
Me.EmployeeAddressCountry.Size = New System.Drawing.Size(181, 16)
Me.EmployeeAddressCountry.Visible=True
me.EmployeeAddressCountry.TabIndex = 10
me.EmployeeAddressCountry.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.EmployeeAddressCountry.TextAlign=HorizontalAlignment.Left


Me.CountryLabel.Name = "CountryLabel"
Me.CountryLabel.Location = New System.Drawing.Point(49, 209)
Me.CountryLabel.Size = New System.Drawing.Size(120, 16)
Me.CountryLabel.Visible=True
me.CountryLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.CountryLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.CountryLabel.Text = "Country"


Me.Telephone.Name = "Telephone"
Me.Telephone.Location = New System.Drawing.Point(175, 230)
Me.Telephone.Size = New System.Drawing.Size(181, 16)
Me.Telephone.Visible=True
me.Telephone.TabIndex = 11
me.Telephone.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.Telephone.TextAlign=HorizontalAlignment.Left


Me.PhoneLabel.Name = "PhoneLabel"
Me.PhoneLabel.Location = New System.Drawing.Point(68, 230)
Me.PhoneLabel.Size = New System.Drawing.Size(101, 16)
Me.PhoneLabel.Visible=True
me.PhoneLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.PhoneLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.PhoneLabel.Text = "Telephone"


Me.MobilePhone.Name = "MobilePhone"
Me.MobilePhone.Location = New System.Drawing.Point(175, 251)
Me.MobilePhone.Size = New System.Drawing.Size(181, 16)
Me.MobilePhone.Visible=True
me.MobilePhone.TabIndex = 12
me.MobilePhone.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.MobilePhone.TextAlign=HorizontalAlignment.Left


Me.MobilePhoneLabel.Name = "MobilePhoneLabel"
Me.MobilePhoneLabel.Location = New System.Drawing.Point(68, 251)
Me.MobilePhoneLabel.Size = New System.Drawing.Size(101, 16)
Me.MobilePhoneLabel.Visible=True
me.MobilePhoneLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.MobilePhoneLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.MobilePhoneLabel.Text = "Mobile Phone"


Me.Telephone2.Name = "Telephone2"
Me.Telephone2.Location = New System.Drawing.Point(175, 272)
Me.Telephone2.Size = New System.Drawing.Size(181, 16)
Me.Telephone2.Visible=True
me.Telephone2.TabIndex = 13
me.Telephone2.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.Telephone2.TextAlign=HorizontalAlignment.Left


Me.Telephone2Label.Name = "Telephone2Label"
Me.Telephone2Label.Location = New System.Drawing.Point(68, 272)
Me.Telephone2Label.Size = New System.Drawing.Size(101, 16)
Me.Telephone2Label.Visible=True
me.Telephone2Label.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.Telephone2Label.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.Telephone2Label.Text = "Other Phone"


Me.Email.Name = "Email"
Me.Email.Location = New System.Drawing.Point(175, 292)
Me.Email.Size = New System.Drawing.Size(181, 16)
Me.Email.Visible=True
me.Email.TabIndex = 14
me.Email.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.Email.TextAlign=HorizontalAlignment.Left


Me.EmailLabel.Name = "EmailLabel"
Me.EmailLabel.Location = New System.Drawing.Point(68, 292)
Me.EmailLabel.Size = New System.Drawing.Size(101, 16)
Me.EmailLabel.Visible=True
me.EmailLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.EmailLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.EmailLabel.Text = "Email"


Me.Genderid.Name = "Genderid"
Me.Genderid.Location = New System.Drawing.Point(175, 313)
Me.Genderid.Size = New System.Drawing.Size(96, 16)
Me.Genderid.Visible=True
me.Genderid.TabIndex = 15
me.Genderid.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Genderid.RowSourceType = "Table/Query"
me.Genderid.RowSource = "vPickListEmployeeGender"

Me.GenderidLabel.Name = "GenderidLabel"
Me.GenderidLabel.Location = New System.Drawing.Point(68, 313)
Me.GenderidLabel.Size = New System.Drawing.Size(101, 16)
Me.GenderidLabel.Visible=True
me.GenderidLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.GenderidLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.GenderidLabel.Text = "Gender"


Me.HiredDate.Name = "HiredDate"
Me.HiredDate.Location = New System.Drawing.Point(543, 19)
Me.HiredDate.Size = New System.Drawing.Size(136, 16)
Me.HiredDate.Visible=True
me.HiredDate.TabIndex = 16
me.HiredDate.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))

Me.HiredDateLabel.Name = "HiredDateLabel"
Me.HiredDateLabel.Location = New System.Drawing.Point(373, 19)
Me.HiredDateLabel.Size = New System.Drawing.Size(163, 16)
Me.HiredDateLabel.Visible=True
me.HiredDateLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.HiredDateLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.HiredDateLabel.Text = "Hired"


Me.CmdCalHireddate.Name = "CmdCalHireddate"
Me.CmdCalHireddate.Location = New System.Drawing.Point(682, 20)
Me.CmdCalHireddate.Size = New System.Drawing.Size(19, 19)
Me.CmdCalHireddate.Visible=True
me.CmdCalHireddate.TabIndex = 17
me.CmdCalHireddate.Font = New System.Drawing.Font("Tahoma", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.CmdCalHireddate.Text = ""
Me.SocialInsuranceNumber.Name = "SocialInsuranceNumber"
Me.SocialInsuranceNumber.Location = New System.Drawing.Point(543, 43)
Me.SocialInsuranceNumber.Size = New System.Drawing.Size(136, 16)
Me.SocialInsuranceNumber.Visible=True
me.SocialInsuranceNumber.TabIndex = 18
me.SocialInsuranceNumber.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.SocialInsuranceNumber.TextAlign=HorizontalAlignment.Left


Me.SocialInsuranceNumberLabel.Name = "SocialInsuranceNumberLabel"
Me.SocialInsuranceNumberLabel.Location = New System.Drawing.Point(373, 43)
Me.SocialInsuranceNumberLabel.Size = New System.Drawing.Size(163, 15)
Me.SocialInsuranceNumberLabel.Visible=True
me.SocialInsuranceNumberLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.SocialInsuranceNumberLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.SocialInsuranceNumberLabel.Text = "Social Insurance Number"


Me.Cyprusidnumber.Name = "Cyprusidnumber"
Me.Cyprusidnumber.Location = New System.Drawing.Point(543, 64)
Me.Cyprusidnumber.Size = New System.Drawing.Size(136, 16)
Me.Cyprusidnumber.Visible=True
me.Cyprusidnumber.TabIndex = 19
me.Cyprusidnumber.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.Cyprusidnumber.TextAlign=HorizontalAlignment.Left


Me.CyprusidnumberLabel.Name = "CyprusidnumberLabel"
Me.CyprusidnumberLabel.Location = New System.Drawing.Point(373, 64)
Me.CyprusidnumberLabel.Size = New System.Drawing.Size(163, 16)
Me.CyprusidnumberLabel.Visible=True
me.CyprusidnumberLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.CyprusidnumberLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.CyprusidnumberLabel.Text = "ID Number"


Me.PayFrequencyID.Name = "PayFrequencyID"
Me.PayFrequencyID.Location = New System.Drawing.Point(543, 85)
Me.PayFrequencyID.Size = New System.Drawing.Size(136, 16)
Me.PayFrequencyID.Visible=True
me.PayFrequencyID.TabIndex = 20
me.PayFrequencyID.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.PayFrequencyID.RowSourceType = "Table/Query"
me.PayFrequencyID.RowSource = "vPickListPayFrequency"

Me.PayFrequencyIDLabel.Name = "PayFrequencyIDLabel"
Me.PayFrequencyIDLabel.Location = New System.Drawing.Point(373, 85)
Me.PayFrequencyIDLabel.Size = New System.Drawing.Size(163, 16)
Me.PayFrequencyIDLabel.Visible=True
me.PayFrequencyIDLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.PayFrequencyIDLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.PayFrequencyIDLabel.Text = "Pay Frequency"

Me.PayFrequencyIDLabel.forecolor = System.Drawing.ColorTranslator.FromOle(13209)

Me.Dateofbirth.Name = "Dateofbirth"
Me.Dateofbirth.Location = New System.Drawing.Point(543, 105)
Me.Dateofbirth.Size = New System.Drawing.Size(136, 16)
Me.Dateofbirth.Visible=True
me.Dateofbirth.TabIndex = 21
me.Dateofbirth.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.Dateofbirth.TextAlign=HorizontalAlignment.Left


Me.DateofbirthLabel.Name = "DateofbirthLabel"
Me.DateofbirthLabel.Location = New System.Drawing.Point(373, 105)
Me.DateofbirthLabel.Size = New System.Drawing.Size(163, 16)
Me.DateofbirthLabel.Visible=True
me.DateofbirthLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.DateofbirthLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.DateofbirthLabel.Text = "Date of Birth"


Me.CmdCalDateofbirth.Name = "CmdCalDateofbirth"
Me.CmdCalDateofbirth.Location = New System.Drawing.Point(682, 105)
Me.CmdCalDateofbirth.Size = New System.Drawing.Size(19, 19)
Me.CmdCalDateofbirth.Visible=True
me.CmdCalDateofbirth.TabIndex = 22
me.CmdCalDateofbirth.Font = New System.Drawing.Font("Tahoma", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.CmdCalDateofbirth.Text = ""
Me.Placeofbirth.Name = "Placeofbirth"
Me.Placeofbirth.Location = New System.Drawing.Point(543, 126)
Me.Placeofbirth.Size = New System.Drawing.Size(136, 16)
Me.Placeofbirth.Visible=True
me.Placeofbirth.TabIndex = 23
me.Placeofbirth.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.Placeofbirth.TextAlign=HorizontalAlignment.Left


Me.PlaceofbirthLabel.Name = "PlaceofbirthLabel"
Me.PlaceofbirthLabel.Location = New System.Drawing.Point(373, 126)
Me.PlaceofbirthLabel.Size = New System.Drawing.Size(163, 16)
Me.PlaceofbirthLabel.Visible=True
me.PlaceofbirthLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.PlaceofbirthLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.PlaceofbirthLabel.Text = "Place of Birth"


Me.Maritalstatus.Name = "Maritalstatus"
Me.Maritalstatus.Location = New System.Drawing.Point(543, 147)
Me.Maritalstatus.Size = New System.Drawing.Size(136, 16)
Me.Maritalstatus.Visible=True
me.Maritalstatus.TabIndex = 24
me.Maritalstatus.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Maritalstatus.RowSourceType = "Table/Query"
me.Maritalstatus.RowSource = "vMaritalStatus"

Me.MaritalstatusLabel.Name = "MaritalstatusLabel"
Me.MaritalstatusLabel.Location = New System.Drawing.Point(373, 147)
Me.MaritalstatusLabel.Size = New System.Drawing.Size(163, 16)
Me.MaritalstatusLabel.Visible=True
me.MaritalstatusLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.MaritalstatusLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.MaritalstatusLabel.Text = "Marital Status"


Me.Professionid.Name = "Professionid"
Me.Professionid.Location = New System.Drawing.Point(543, 168)
Me.Professionid.Size = New System.Drawing.Size(136, 16)
Me.Professionid.Visible=True
me.Professionid.TabIndex = 25
me.Professionid.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Professionid.RowSourceType = "Table/Query"
me.Professionid.RowSource = "EmployeeProfession"

Me.ProfessionLabel.Name = "ProfessionLabel"
Me.ProfessionLabel.Location = New System.Drawing.Point(373, 168)
Me.ProfessionLabel.Size = New System.Drawing.Size(163, 16)
Me.ProfessionLabel.Visible=True
me.ProfessionLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.ProfessionLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.ProfessionLabel.Text = "Profession"


Me.AlienIDNumber.Name = "AlienIDNumber"
Me.AlienIDNumber.Location = New System.Drawing.Point(543, 189)
Me.AlienIDNumber.Size = New System.Drawing.Size(136, 16)
Me.AlienIDNumber.Visible=True
me.AlienIDNumber.TabIndex = 26
me.AlienIDNumber.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.AlienIDNumber.TextAlign=HorizontalAlignment.Left


Me.AlienIDNumberLabel.Name = "AlienIDNumberLabel"
Me.AlienIDNumberLabel.Location = New System.Drawing.Point(373, 189)
Me.AlienIDNumberLabel.Size = New System.Drawing.Size(163, 16)
Me.AlienIDNumberLabel.Visible=True
me.AlienIDNumberLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.AlienIDNumberLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.AlienIDNumberLabel.Text = "Alien ID Number"


Me.PassportNumber.Name = "PassportNumber"
Me.PassportNumber.Location = New System.Drawing.Point(543, 209)
Me.PassportNumber.Size = New System.Drawing.Size(138, 16)
Me.PassportNumber.Visible=True
me.PassportNumber.TabIndex = 27
me.PassportNumber.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.PassportNumber.TextAlign=HorizontalAlignment.Left


Me.PassportNumberLabel.Name = "PassportNumberLabel"
Me.PassportNumberLabel.Location = New System.Drawing.Point(373, 209)
Me.PassportNumberLabel.Size = New System.Drawing.Size(163, 16)
Me.PassportNumberLabel.Visible=True
me.PassportNumberLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.PassportNumberLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.PassportNumberLabel.Text = "Passport Number"


Me.SocinsCategoryid.Name = "SocinsCategoryid"
Me.SocinsCategoryid.Location = New System.Drawing.Point(543, 230)
Me.SocinsCategoryid.Size = New System.Drawing.Size(138, 16)
Me.SocinsCategoryid.Visible=True
me.SocinsCategoryid.TabIndex = 28
me.SocinsCategoryid.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.SocinsCategoryid.RowSourceType = "Table/Query"
me.SocinsCategoryid.RowSource = "EmployeeSocialInsuranceType"

Me.SocinsCategoryLabel.Name = "SocinsCategoryLabel"
Me.SocinsCategoryLabel.Location = New System.Drawing.Point(373, 230)
Me.SocinsCategoryLabel.Size = New System.Drawing.Size(163, 16)
Me.SocinsCategoryLabel.Visible=True
me.SocinsCategoryLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.SocinsCategoryLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.SocinsCategoryLabel.Text = "Soc. Ins. Type"

Me.SocinsCategoryLabel.forecolor = System.Drawing.ColorTranslator.FromOle(13209)

Me.Ssicommunityid.Name = "Ssicommunityid"
Me.Ssicommunityid.Location = New System.Drawing.Point(543, 251)
Me.Ssicommunityid.Size = New System.Drawing.Size(138, 16)
Me.Ssicommunityid.Visible=True
me.Ssicommunityid.TabIndex = 29
me.Ssicommunityid.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Ssicommunityid.RowSourceType = "Table/Query"
me.Ssicommunityid.RowSource = "vPickListSSIComunity"

Me.SsicommunityidLabel.Name = "SsicommunityidLabel"
Me.SsicommunityidLabel.Location = New System.Drawing.Point(372, 251)
Me.SsicommunityidLabel.Size = New System.Drawing.Size(164, 16)
Me.SsicommunityidLabel.Visible=True
me.SsicommunityidLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.SsicommunityidLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.SsicommunityidLabel.Text = "Soc. Ins. Community"


Me.DriverLicenceNo.Name = "DriverLicenceNo"
Me.DriverLicenceNo.Location = New System.Drawing.Point(543, 272)
Me.DriverLicenceNo.Size = New System.Drawing.Size(138, 16)
Me.DriverLicenceNo.Visible=True
me.DriverLicenceNo.TabIndex = 30
me.DriverLicenceNo.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.DriverLicenceNo.TextAlign=HorizontalAlignment.Left


Me.DriverLicenceNoLabel.Name = "DriverLicenceNoLabel"
Me.DriverLicenceNoLabel.Location = New System.Drawing.Point(373, 272)
Me.DriverLicenceNoLabel.Size = New System.Drawing.Size(163, 16)
Me.DriverLicenceNoLabel.Visible=True
me.DriverLicenceNoLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.DriverLicenceNoLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.DriverLicenceNoLabel.Text = "Driver License No"


Me.ITaxIdNumber.Name = "ITaxIdNumber"
Me.ITaxIdNumber.Location = New System.Drawing.Point(543, 293)
Me.ITaxIdNumber.Size = New System.Drawing.Size(138, 16)
Me.ITaxIdNumber.Visible=True
me.ITaxIdNumber.TabIndex = 31
me.ITaxIdNumber.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.ITaxIdNumber.TextAlign=HorizontalAlignment.Left


Me.ITaxIdNumberLabel.Name = "ITaxIdNumberLabel"
Me.ITaxIdNumberLabel.Location = New System.Drawing.Point(373, 293)
Me.ITaxIdNumberLabel.Size = New System.Drawing.Size(163, 16)
Me.ITaxIdNumberLabel.Visible=True
me.ITaxIdNumberLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.ITaxIdNumberLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.ITaxIdNumberLabel.Text = "Income Tax ID No"


Me.CSSId.Name = "CSSId"
Me.CSSId.Location = New System.Drawing.Point(543, 316)
Me.CSSId.Size = New System.Drawing.Size(138, 16)
Me.CSSId.Visible=True
me.CSSId.TabIndex = 32
me.CSSId.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.CSSId.RowSourceType = "Table/Query"
me.CSSId.RowSource = "CompanySSIDepts"

Me.CSSIdLabel.Name = "CSSIdLabel"
Me.CSSIdLabel.Location = New System.Drawing.Point(373, 316)
Me.CSSIdLabel.Size = New System.Drawing.Size(163, 16)
Me.CSSIdLabel.Visible=True
me.CSSIdLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.CSSIdLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.CSSIdLabel.Text = "Social Insurance Dpt"

Me.CSSIdLabel.forecolor = System.Drawing.ColorTranslator.FromOle(13209)

Me.CmdChangeHireDate.Name = "CmdChangeHireDate"
Me.CmdChangeHireDate.Location = New System.Drawing.Point(705, 20)
Me.CmdChangeHireDate.Size = New System.Drawing.Size(25, 18)
Me.CmdChangeHireDate.Visible=True
me.CmdChangeHireDate.TabIndex = 33
me.CmdChangeHireDate.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.CmdChangeHireDate.Text = "..."
Me.CmdChangeHireDate.forecolor = System.Drawing.ColorTranslator.FromOle(-2147483630)
Me.PgPayroll.Name = "PgPayroll"
Me.PgPayroll.Location = New System.Drawing.Point(9, 33)
Me.PgPayroll.Size = New System.Drawing.Size(786, 354)
Me.PgPayroll.Visible=True
Me.PgPayroll.Text = "Payroll"

Me.ColaAdjusted.Name = "ColaAdjusted"
Me.ColaAdjusted.Location = New System.Drawing.Point(17, 11)
Me.ColaAdjusted.Size = New System.Drawing.Size(14, 14)
Me.ColaAdjusted.Visible=False
me.ColaAdjusted.TabIndex = 0
Me.ColaadjustedLabel.Name = "ColaadjustedLabel"
Me.ColaadjustedLabel.Location = New System.Drawing.Point(32, 9)
Me.ColaadjustedLabel.Size = New System.Drawing.Size(163, 16)
Me.ColaadjustedLabel.Visible=True
me.ColaadjustedLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.ColaadjustedLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft
Me.ColaadjustedLabel.Text = "Salary based on COLA"


Me.RegularDaysHoursLabel.Name = "RegularDaysHoursLabel"
Me.RegularDaysHoursLabel.Location = New System.Drawing.Point(75, 196)
Me.RegularDaysHoursLabel.Size = New System.Drawing.Size(112, 29)
Me.RegularDaysHoursLabel.Visible=True
me.RegularDaysHoursLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.RegularDaysHoursLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.RegularDaysHoursLabel.Text = "Regular Days and" & vbCrLf & "Hours of Work"


Me.CmdChangeSalaries.Name = "CmdChangeSalaries"
Me.CmdChangeSalaries.Location = New System.Drawing.Point(320, 7)
Me.CmdChangeSalaries.Size = New System.Drawing.Size(110, 20)
Me.CmdChangeSalaries.Visible=True
me.CmdChangeSalaries.TabIndex = 1
me.CmdChangeSalaries.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.CmdChangeSalaries.Text = "Change Salary"
Me.CmdChangeSalaries.forecolor = System.Drawing.ColorTranslator.FromOle(-2147483630)
Me.CompanyPaidTaxesLabel.Name = "CompanyPaidTaxesLabel"
Me.CompanyPaidTaxesLabel.Location = New System.Drawing.Point(456, 21)
Me.CompanyPaidTaxesLabel.Size = New System.Drawing.Size(329, 16)
Me.CompanyPaidTaxesLabel.Visible=True
me.CompanyPaidTaxesLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.CompanyPaidTaxesLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft
Me.CompanyPaidTaxesLabel.Text = "Company Paid Taxes and Contributions"

Me.CompanyPaidTaxesLabel.backcolor = System.Drawing.ColorTranslator.FromOle(-2147483633)

Me.IncreaseMonth.Name = "IncreaseMonth"
Me.IncreaseMonth.Location = New System.Drawing.Point(195, 127)
Me.IncreaseMonth.Size = New System.Drawing.Size(70, 16)
Me.IncreaseMonth.Visible=True
me.IncreaseMonth.TabIndex = 3
me.IncreaseMonth.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.IncreaseMonth.RowSourceType = "Value List"
me.IncreaseMonth.RowSource = "1;2;3;4;5;6;7;8;9;10;11;12"

Me.IncreaseMonthLabel.Name = "IncreaseMonthLabel"
Me.IncreaseMonthLabel.Location = New System.Drawing.Point(96, 127)
Me.IncreaseMonthLabel.Size = New System.Drawing.Size(91, 16)
Me.IncreaseMonthLabel.Visible=True
me.IncreaseMonthLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.IncreaseMonthLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.IncreaseMonthLabel.Text = "Increase Month"


Me.HourlySalaryCalcMethodID.Name = "HourlySalaryCalcMethodID"
Me.HourlySalaryCalcMethodID.Location = New System.Drawing.Point(196, 150)
Me.HourlySalaryCalcMethodID.Size = New System.Drawing.Size(236, 17)
Me.HourlySalaryCalcMethodID.Visible=True
me.HourlySalaryCalcMethodID.TabIndex = 4
me.HourlySalaryCalcMethodID.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.HourlySalaryCalcMethodID.RowSourceType = "Table/Query"
me.HourlySalaryCalcMethodID.RowSource = "vPickListHourlySalCalcMethod"

Me.HourSalaryCalculationMethodLabel.Name = "HourSalaryCalculationMethodLabel"
Me.HourSalaryCalculationMethodLabel.Location = New System.Drawing.Point(46, 150)
Me.HourSalaryCalculationMethodLabel.Size = New System.Drawing.Size(141, 28)
Me.HourSalaryCalculationMethodLabel.Visible=True
me.HourSalaryCalculationMethodLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.HourSalaryCalculationMethodLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.HourSalaryCalculationMethodLabel.Text = "Salary Per Hour Calculation Method"

Me.HourSalaryCalculationMethodLabel.forecolor = System.Drawing.ColorTranslator.FromOle(13209)

Me.FixedHoursPerPeriod.Name = "FixedHoursPerPeriod"
Me.FixedHoursPerPeriod.Location = New System.Drawing.Point(376, 173)
Me.FixedHoursPerPeriod.Size = New System.Drawing.Size(57, 16)
Me.FixedHoursPerPeriod.Visible=False
me.FixedHoursPerPeriod.TabIndex = 5
me.FixedHoursPerPeriod.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.FixedHoursPerPeriod.TextAlign=HorizontalAlignment.Left


Me.FixedHoursPerPeriodLabel.Name = "FixedHoursPerPeriodLabel"
Me.FixedHoursPerPeriodLabel.Location = New System.Drawing.Point(145, 173)
Me.FixedHoursPerPeriodLabel.Size = New System.Drawing.Size(226, 16)
Me.FixedHoursPerPeriodLabel.Visible=True
me.FixedHoursPerPeriodLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.FixedHoursPerPeriodLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.FixedHoursPerPeriodLabel.Text = "Fixed Work Hours Per Pay Period"


Me.DayLabel1.Name = "DayLabel1"
Me.DayLabel1.Location = New System.Drawing.Point(194, 196)
Me.DayLabel1.Size = New System.Drawing.Size(101, 15)
Me.DayLabel1.Visible=True
me.DayLabel1.TabIndex = 6
me.DayLabel1.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.DayLabel1.backcolor =me.backcolor
me.DayLabel1.ReadOnly = True
me.DayLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.DayLabel1.TextAlign=HorizontalAlignment.Left


Me.Timein1.Name = "Timein1"
Me.Timein1.Location = New System.Drawing.Point(304, 196)
Me.Timein1.Size = New System.Drawing.Size(31, 15)
Me.Timein1.Visible=False
me.Timein1.TabIndex = 7
me.Timein1.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Timein1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.Timein1.TextAlign=HorizontalAlignment.Right


Me.Timeout1.Name = "Timeout1"
Me.Timeout1.Location = New System.Drawing.Point(339, 196)
Me.Timeout1.Size = New System.Drawing.Size(31, 15)
Me.Timeout1.Visible=False
me.Timeout1.TabIndex = 8
me.Timeout1.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Timeout1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.Timeout1.TextAlign=HorizontalAlignment.Right


Me.RegularHours1.Name = "RegularHours1"
Me.RegularHours1.Location = New System.Drawing.Point(304, 196)
Me.RegularHours1.Size = New System.Drawing.Size(31, 15)
Me.RegularHours1.Visible=True
me.RegularHours1.TabIndex = 9
me.RegularHours1.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.RegularHours1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.RegularHours1.TextAlign=HorizontalAlignment.Right


Me.DayLabel2.Name = "DayLabel2"
Me.DayLabel2.Location = New System.Drawing.Point(194, 211)
Me.DayLabel2.Size = New System.Drawing.Size(101, 15)
Me.DayLabel2.Visible=True
me.DayLabel2.TabIndex = 10
me.DayLabel2.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.DayLabel2.backcolor =me.backcolor
me.DayLabel2.ReadOnly = True
me.DayLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.DayLabel2.TextAlign=HorizontalAlignment.Left


Me.Timein2.Name = "Timein2"
Me.Timein2.Location = New System.Drawing.Point(304, 211)
Me.Timein2.Size = New System.Drawing.Size(31, 15)
Me.Timein2.Visible=False
me.Timein2.TabIndex = 11
me.Timein2.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Timein2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.Timein2.TextAlign=HorizontalAlignment.Right


Me.Timeout2.Name = "Timeout2"
Me.Timeout2.Location = New System.Drawing.Point(339, 211)
Me.Timeout2.Size = New System.Drawing.Size(31, 15)
Me.Timeout2.Visible=False
me.Timeout2.TabIndex = 12
me.Timeout2.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Timeout2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.Timeout2.TextAlign=HorizontalAlignment.Right


Me.RegularHours2.Name = "RegularHours2"
Me.RegularHours2.Location = New System.Drawing.Point(304, 211)
Me.RegularHours2.Size = New System.Drawing.Size(31, 15)
Me.RegularHours2.Visible=True
me.RegularHours2.TabIndex = 13
me.RegularHours2.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.RegularHours2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.RegularHours2.TextAlign=HorizontalAlignment.Right


Me.DayLabel3.Name = "DayLabel3"
Me.DayLabel3.Location = New System.Drawing.Point(194, 226)
Me.DayLabel3.Size = New System.Drawing.Size(101, 15)
Me.DayLabel3.Visible=True
me.DayLabel3.TabIndex = 14
me.DayLabel3.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.DayLabel3.backcolor =me.backcolor
me.DayLabel3.ReadOnly = True
me.DayLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.DayLabel3.TextAlign=HorizontalAlignment.Left


Me.Timein3.Name = "Timein3"
Me.Timein3.Location = New System.Drawing.Point(304, 226)
Me.Timein3.Size = New System.Drawing.Size(31, 15)
Me.Timein3.Visible=False
me.Timein3.TabIndex = 15
me.Timein3.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Timein3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.Timein3.TextAlign=HorizontalAlignment.Right


Me.Timeout3.Name = "Timeout3"
Me.Timeout3.Location = New System.Drawing.Point(339, 226)
Me.Timeout3.Size = New System.Drawing.Size(31, 15)
Me.Timeout3.Visible=False
me.Timeout3.TabIndex = 16
me.Timeout3.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Timeout3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.Timeout3.TextAlign=HorizontalAlignment.Right


Me.RegularHours3.Name = "RegularHours3"
Me.RegularHours3.Location = New System.Drawing.Point(304, 226)
Me.RegularHours3.Size = New System.Drawing.Size(31, 15)
Me.RegularHours3.Visible=True
me.RegularHours3.TabIndex = 17
me.RegularHours3.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.RegularHours3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.RegularHours3.TextAlign=HorizontalAlignment.Right


Me.EmployeePaidTaxesLabel.Name = "EmployeePaidTaxesLabel"
Me.EmployeePaidTaxesLabel.Location = New System.Drawing.Point(456, 208)
Me.EmployeePaidTaxesLabel.Size = New System.Drawing.Size(333, 17)
Me.EmployeePaidTaxesLabel.Visible=True
me.EmployeePaidTaxesLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.EmployeePaidTaxesLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft
Me.EmployeePaidTaxesLabel.Text = "Employee Deductions, Contributions, Additions and Taxes"

Me.EmployeePaidTaxesLabel.backcolor = System.Drawing.ColorTranslator.FromOle(-2147483633)

Me.CmdDefaults.Name = "CmdDefaults"
Me.CmdDefaults.Location = New System.Drawing.Point(50, 230)
Me.CmdDefaults.Size = New System.Drawing.Size(96, 20)
Me.CmdDefaults.Visible=True
me.CmdDefaults.TabIndex = 19
me.CmdDefaults.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.CmdDefaults.Text = "Defaults"
Me.DayLabel4.Name = "DayLabel4"
Me.DayLabel4.Location = New System.Drawing.Point(194, 241)
Me.DayLabel4.Size = New System.Drawing.Size(101, 15)
Me.DayLabel4.Visible=True
me.DayLabel4.TabIndex = 20
me.DayLabel4.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.DayLabel4.backcolor =me.backcolor
me.DayLabel4.ReadOnly = True
me.DayLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.DayLabel4.TextAlign=HorizontalAlignment.Left


Me.Timein4.Name = "Timein4"
Me.Timein4.Location = New System.Drawing.Point(304, 241)
Me.Timein4.Size = New System.Drawing.Size(31, 15)
Me.Timein4.Visible=False
me.Timein4.TabIndex = 21
me.Timein4.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Timein4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.Timein4.TextAlign=HorizontalAlignment.Right


Me.Timeout4.Name = "Timeout4"
Me.Timeout4.Location = New System.Drawing.Point(339, 241)
Me.Timeout4.Size = New System.Drawing.Size(31, 15)
Me.Timeout4.Visible=False
me.Timeout4.TabIndex = 22
me.Timeout4.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Timeout4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.Timeout4.TextAlign=HorizontalAlignment.Right


Me.RegularHours4.Name = "RegularHours4"
Me.RegularHours4.Location = New System.Drawing.Point(304, 241)
Me.RegularHours4.Size = New System.Drawing.Size(31, 15)
Me.RegularHours4.Visible=True
me.RegularHours4.TabIndex = 23
me.RegularHours4.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.RegularHours4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.RegularHours4.TextAlign=HorizontalAlignment.Right


Me.DayLabel5.Name = "DayLabel5"
Me.DayLabel5.Location = New System.Drawing.Point(194, 256)
Me.DayLabel5.Size = New System.Drawing.Size(101, 15)
Me.DayLabel5.Visible=True
me.DayLabel5.TabIndex = 24
me.DayLabel5.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.DayLabel5.backcolor =me.backcolor
me.DayLabel5.ReadOnly = True
me.DayLabel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.DayLabel5.TextAlign=HorizontalAlignment.Left


Me.Timein5.Name = "Timein5"
Me.Timein5.Location = New System.Drawing.Point(304, 256)
Me.Timein5.Size = New System.Drawing.Size(31, 15)
Me.Timein5.Visible=False
me.Timein5.TabIndex = 25
me.Timein5.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Timein5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.Timein5.TextAlign=HorizontalAlignment.Right


Me.Timeout5.Name = "Timeout5"
Me.Timeout5.Location = New System.Drawing.Point(339, 256)
Me.Timeout5.Size = New System.Drawing.Size(31, 15)
Me.Timeout5.Visible=False
me.Timeout5.TabIndex = 26
me.Timeout5.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Timeout5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.Timeout5.TextAlign=HorizontalAlignment.Right


Me.RegularHours5.Name = "RegularHours5"
Me.RegularHours5.Location = New System.Drawing.Point(304, 256)
Me.RegularHours5.Size = New System.Drawing.Size(31, 15)
Me.RegularHours5.Visible=True
me.RegularHours5.TabIndex = 27
me.RegularHours5.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.RegularHours5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.RegularHours5.TextAlign=HorizontalAlignment.Right


Me.DayLabel6.Name = "DayLabel6"
Me.DayLabel6.Location = New System.Drawing.Point(194, 271)
Me.DayLabel6.Size = New System.Drawing.Size(101, 15)
Me.DayLabel6.Visible=True
me.DayLabel6.TabIndex = 28
me.DayLabel6.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.DayLabel6.backcolor =me.backcolor
me.DayLabel6.ReadOnly = True
me.DayLabel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.DayLabel6.TextAlign=HorizontalAlignment.Left


Me.Timein6.Name = "Timein6"
Me.Timein6.Location = New System.Drawing.Point(304, 271)
Me.Timein6.Size = New System.Drawing.Size(31, 15)
Me.Timein6.Visible=False
me.Timein6.TabIndex = 29
me.Timein6.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Timein6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.Timein6.TextAlign=HorizontalAlignment.Right


Me.Timeout6.Name = "Timeout6"
Me.Timeout6.Location = New System.Drawing.Point(339, 271)
Me.Timeout6.Size = New System.Drawing.Size(31, 15)
Me.Timeout6.Visible=False
me.Timeout6.TabIndex = 30
me.Timeout6.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Timeout6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.Timeout6.TextAlign=HorizontalAlignment.Right


Me.Box125.Name = "Box125"
Me.Box125.Location = New System.Drawing.Point(450, 16)
Me.Box125.Size = New System.Drawing.Size(343, 330)
Me.Box125.Visible=True
Me.RegularHours6.Name = "RegularHours6"
Me.RegularHours6.Location = New System.Drawing.Point(304, 271)
Me.RegularHours6.Size = New System.Drawing.Size(31, 15)
Me.RegularHours6.Visible=True
me.RegularHours6.TabIndex = 31
me.RegularHours6.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.RegularHours6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.RegularHours6.TextAlign=HorizontalAlignment.Right


Me.DayLabel7.Name = "DayLabel7"
Me.DayLabel7.Location = New System.Drawing.Point(194, 286)
Me.DayLabel7.Size = New System.Drawing.Size(101, 15)
Me.DayLabel7.Visible=True
me.DayLabel7.TabIndex = 32
me.DayLabel7.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.DayLabel7.backcolor =me.backcolor
me.DayLabel7.ReadOnly = True
me.DayLabel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.DayLabel7.TextAlign=HorizontalAlignment.Left


Me.Timein7.Name = "Timein7"
Me.Timein7.Location = New System.Drawing.Point(304, 286)
Me.Timein7.Size = New System.Drawing.Size(31, 15)
Me.Timein7.Visible=False
me.Timein7.TabIndex = 33
me.Timein7.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Timein7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.Timein7.TextAlign=HorizontalAlignment.Right


Me.Timeout7.Name = "Timeout7"
Me.Timeout7.Location = New System.Drawing.Point(339, 286)
Me.Timeout7.Size = New System.Drawing.Size(31, 15)
Me.Timeout7.Visible=False
me.Timeout7.TabIndex = 34
me.Timeout7.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Timeout7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.Timeout7.TextAlign=HorizontalAlignment.Right


Me.RegularHours7.Name = "RegularHours7"
Me.RegularHours7.Location = New System.Drawing.Point(304, 286)
Me.RegularHours7.Size = New System.Drawing.Size(31, 15)
Me.RegularHours7.Visible=True
me.RegularHours7.TabIndex = 35
me.RegularHours7.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.RegularHours7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.RegularHours7.TextAlign=HorizontalAlignment.Right


Me.TxtTotHours.Name = "TxtTotHours"
Me.TxtTotHours.Location = New System.Drawing.Point(304, 304)
Me.TxtTotHours.Size = New System.Drawing.Size(31, 15)
Me.TxtTotHours.Visible=True
me.TxtTotHours.TabIndex = 36
me.TxtTotHours.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.TxtTotHours.backcolor =me.backcolor
me.TxtTotHours.ReadOnly = True
me.TxtTotHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.TxtTotHours.TextAlign=HorizontalAlignment.Right


Me.EmployeeTypeID.Name = "EmployeeTypeID"
Me.EmployeeTypeID.Location = New System.Drawing.Point(189, 324)
Me.EmployeeTypeID.Size = New System.Drawing.Size(239, 16)
Me.EmployeeTypeID.Visible=True
me.EmployeeTypeID.TabIndex = 37
me.EmployeeTypeID.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.EmployeeTypeID.RowSourceType = "Table/Query"
me.EmployeeTypeID.RowSource = "employeeType"

Me.EmployeetypeLabel.Name = "EmployeetypeLabel"
Me.EmployeetypeLabel.Location = New System.Drawing.Point(55, 324)
Me.EmployeetypeLabel.Size = New System.Drawing.Size(129, 16)
Me.EmployeetypeLabel.Visible=True
me.EmployeetypeLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.EmployeetypeLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.EmployeetypeLabel.Text = "Employee Group"


Me.ChildEmployeeSalaryHistory.Name = "ChildEmployeeSalaryHistory"
Me.ChildEmployeeSalaryHistory.Location = New System.Drawing.Point(13, 32)
Me.ChildEmployeeSalaryHistory.Size = New System.Drawing.Size(417, 86)
Me.ChildEmployeeSalaryHistory.Visible=True
me.ChildEmployeeSalaryHistory.TabIndex = 38
me.ChildEmployeeSalaryHistory.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.ChildEmployeeSalaryHistory.RowSourceType = "Table/Query"
me.ChildEmployeeSalaryHistory.RowSource = ""

Me.CmdDeleteSalary.Name = "CmdDeleteSalary"
Me.CmdDeleteSalary.Location = New System.Drawing.Point(209, 7)
Me.CmdDeleteSalary.Size = New System.Drawing.Size(104, 20)
Me.CmdDeleteSalary.Visible=True
me.CmdDeleteSalary.TabIndex = 39
me.CmdDeleteSalary.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.CmdDeleteSalary.Text = "Delete Salary"
Me.CmdDeleteSalary.forecolor = System.Drawing.ColorTranslator.FromOle(-2147483630)
Me.PgOtherInfo.Name = "PgOtherInfo"
Me.PgOtherInfo.Location = New System.Drawing.Point(9, 33)
Me.PgOtherInfo.Size = New System.Drawing.Size(786, 354)
Me.PgOtherInfo.Visible=True
Me.PgOtherInfo.Text = "Other"

Me.ChkisSystemUser.Name = "ChkisSystemUser"
Me.ChkisSystemUser.Location = New System.Drawing.Point(160, 21)
Me.ChkisSystemUser.Size = New System.Drawing.Size(14, 14)
Me.ChkisSystemUser.Visible=True
me.ChkisSystemUser.TabIndex = 0
Me.SystemUserLabel.Name = "SystemUserLabel"
Me.SystemUserLabel.Location = New System.Drawing.Point(175, 21)
Me.SystemUserLabel.Size = New System.Drawing.Size(137, 16)
Me.SystemUserLabel.Visible=True
me.SystemUserLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.SystemUserLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft
Me.SystemUserLabel.Text = "Is System User:"


Me.Username.Name = "Username"
Me.Username.Location = New System.Drawing.Point(201, 41)
Me.Username.Size = New System.Drawing.Size(105, 16)
Me.Username.Visible=True
me.Username.TabIndex = 1
me.Username.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Username.backcolor =me.backcolor
me.Username.ReadOnly = True
Me.Username.TextAlign=HorizontalAlignment.Left


Me.UsernameLabel.Name = "UsernameLabel"
Me.UsernameLabel.Location = New System.Drawing.Point(83, 41)
Me.UsernameLabel.Size = New System.Drawing.Size(114, 16)
Me.UsernameLabel.Visible=True
me.UsernameLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.UsernameLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.UsernameLabel.Text = "Username"


Me.DaysLabel.Name = "DaysLabel"
Me.DaysLabel.Location = New System.Drawing.Point(261, 180)
Me.DaysLabel.Size = New System.Drawing.Size(98, 16)
Me.DaysLabel.Visible=True
me.DaysLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.DaysLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft
Me.DaysLabel.Text = "days with company"


Me.ActiveLabelHelp.Name = "ActiveLabelHelp"
Me.ActiveLabelHelp.Location = New System.Drawing.Point(158, 202)
Me.ActiveLabelHelp.Size = New System.Drawing.Size(222, 68)
Me.ActiveLabelHelp.Visible=True
me.ActiveLabelHelp.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.ActiveLabelHelp.TextAlign=System.Drawing.ContentAlignment.MiddleLeft
Me.ActiveLabelHelp.Text = "Non active employees cannot be paid."


Me.Box163.Name = "Box163"
Me.Box163.Location = New System.Drawing.Point(55, 17)
Me.Box163.Size = New System.Drawing.Size(304, 112)
Me.Box163.Visible=True
Me.Password.Name = "Password"
Me.Password.Location = New System.Drawing.Point(201, 61)
Me.Password.Size = New System.Drawing.Size(105, 16)
Me.Password.Visible=True
me.Password.TabIndex = 2
me.Password.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Password.backcolor =me.backcolor
me.Password.ReadOnly = True
Me.Password.TextAlign=HorizontalAlignment.Left


Me.PasswordLabel.Name = "PasswordLabel"
Me.PasswordLabel.Location = New System.Drawing.Point(83, 61)
Me.PasswordLabel.Size = New System.Drawing.Size(114, 16)
Me.PasswordLabel.Visible=True
me.PasswordLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.PasswordLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.PasswordLabel.Text = "Password"


Me.SecurityLevelId.Name = "SecurityLevelId"
Me.SecurityLevelId.Location = New System.Drawing.Point(92, 104)
Me.SecurityLevelId.Size = New System.Drawing.Size(218, 16)
Me.SecurityLevelId.Visible=False
me.SecurityLevelId.TabIndex = 3
me.SecurityLevelId.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.SecurityLevelId.RowSourceType = "Table/Query"
me.SecurityLevelId.RowSource = "vPickListSecurityRoleAcc"

Me.RightsLabel.Name = "RightsLabel"
Me.RightsLabel.Location = New System.Drawing.Point(81, 82)
Me.RightsLabel.Size = New System.Drawing.Size(191, 16)
Me.RightsLabel.Visible=True
me.RightsLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.RightsLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft
Me.RightsLabel.Text = "Security Level"


Me.PayslipLanguage.Name = "PayslipLanguage"
Me.PayslipLanguage.Location = New System.Drawing.Point(207, 148)
Me.PayslipLanguage.Size = New System.Drawing.Size(149, 16)
Me.PayslipLanguage.Visible=True
me.PayslipLanguage.TabIndex = 4
me.PayslipLanguage.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.PayslipLanguage.RowSourceType = "Value List"
me.PayslipLanguage.RowSource = "'en';'English/Αγγλικά';'gr';'Greek/Ελληνικά'"

Me.PayslipLanguageLabel.Name = "PayslipLanguageLabel"
Me.PayslipLanguageLabel.Location = New System.Drawing.Point(56, 148)
Me.PayslipLanguageLabel.Size = New System.Drawing.Size(141, 16)
Me.PayslipLanguageLabel.Visible=True
me.PayslipLanguageLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.PayslipLanguageLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.PayslipLanguageLabel.Text = "Payslip Language"


Me.HolidaysPaidAfterDays.Name = "HolidaysPaidAfterDays"
Me.HolidaysPaidAfterDays.Location = New System.Drawing.Point(224, 180)
Me.HolidaysPaidAfterDays.Size = New System.Drawing.Size(35, 16)
Me.HolidaysPaidAfterDays.Visible=True
me.HolidaysPaidAfterDays.TabIndex = 5
me.HolidaysPaidAfterDays.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.HolidaysPaidAfterDays.TextAlign=HorizontalAlignment.Left


Me.ChkHolidaysPaid.Name = "ChkHolidaysPaid"
Me.ChkHolidaysPaid.Location = New System.Drawing.Point(60, 183)
Me.ChkHolidaysPaid.Size = New System.Drawing.Size(14, 14)
Me.ChkHolidaysPaid.Visible=True
me.ChkHolidaysPaid.TabIndex = 6
Me.HolidaysPaidLabel.Name = "HolidaysPaidLabel"
Me.HolidaysPaidLabel.Location = New System.Drawing.Point(75, 181)
Me.HolidaysPaidLabel.Size = New System.Drawing.Size(146, 15)
Me.HolidaysPaidLabel.Visible=True
me.HolidaysPaidLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.HolidaysPaidLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft
Me.HolidaysPaidLabel.Text = "Holidays Paid after"


Me.ChkIsActive.Name = "ChkIsActive"
Me.ChkIsActive.Location = New System.Drawing.Point(145, 206)
Me.ChkIsActive.Size = New System.Drawing.Size(14, 14)
Me.ChkIsActive.Visible=True
me.ChkIsActive.TabIndex = 7
Me.IsActiveLabel.Name = "IsActiveLabel"
Me.IsActiveLabel.Location = New System.Drawing.Point(44, 203)
Me.IsActiveLabel.Size = New System.Drawing.Size(92, 16)
Me.IsActiveLabel.Visible=True
me.IsActiveLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.IsActiveLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.IsActiveLabel.Text = "Active"

Me.IsActiveLabel.forecolor = System.Drawing.ColorTranslator.FromOle(13209)

Me.Unionid.Name = "Unionid"
Me.Unionid.Location = New System.Drawing.Point(539, 24)
Me.Unionid.Size = New System.Drawing.Size(239, 16)
Me.Unionid.Visible=True
me.Unionid.TabIndex = 8
me.Unionid.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Unionid.RowSourceType = "Table/Query"
me.Unionid.RowSource = "vEmployeeUnion"

Me.UnionLabel.Name = "UnionLabel"
Me.UnionLabel.Location = New System.Drawing.Point(405, 24)
Me.UnionLabel.Size = New System.Drawing.Size(129, 16)
Me.UnionLabel.Visible=True
me.UnionLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.UnionLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.UnionLabel.Text = "Union"


Me.Notes.Name = "Notes"
Me.Notes.Location = New System.Drawing.Point(539, 46)
Me.Notes.Size = New System.Drawing.Size(239, 124)
Me.Notes.Visible=True
me.Notes.TabIndex = 9
me.Notes.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Notes.Multiline = True
Me.Notes.TextAlign=HorizontalAlignment.Left


Me.NotesLabel.Name = "NotesLabel"
Me.NotesLabel.Location = New System.Drawing.Point(405, 46)
Me.NotesLabel.Size = New System.Drawing.Size(129, 16)
Me.NotesLabel.Visible=True
me.NotesLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.NotesLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.NotesLabel.Text = "Notes"


Me.DefaultServiceItemid.Name = "DefaultServiceItemid"
Me.DefaultServiceItemid.Location = New System.Drawing.Point(539, 199)
Me.DefaultServiceItemid.Size = New System.Drawing.Size(239, 16)
Me.DefaultServiceItemid.Visible=False
me.DefaultServiceItemid.TabIndex = 10
me.DefaultServiceItemid.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.DefaultServiceItemid.RowSourceType = "Table/Query"
me.DefaultServiceItemid.RowSource = "vServiceItems"

Me.DefaultServiceItemidLabel.Name = "DefaultServiceItemidLabel"
Me.DefaultServiceItemidLabel.Location = New System.Drawing.Point(405, 199)
Me.DefaultServiceItemidLabel.Size = New System.Drawing.Size(129, 16)
Me.DefaultServiceItemidLabel.Visible=True
me.DefaultServiceItemidLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.DefaultServiceItemidLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.DefaultServiceItemidLabel.Text = "Default Service"


Me.Defaultprojectid.Name = "Defaultprojectid"
Me.Defaultprojectid.Location = New System.Drawing.Point(539, 221)
Me.Defaultprojectid.Size = New System.Drawing.Size(239, 16)
Me.Defaultprojectid.Visible=False
me.Defaultprojectid.TabIndex = 11
me.Defaultprojectid.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Defaultprojectid.RowSourceType = "Table/Query"
me.Defaultprojectid.RowSource = "vProjects"

Me.DefaultprojectidLabel.Name = "DefaultprojectidLabel"
Me.DefaultprojectidLabel.Location = New System.Drawing.Point(405, 221)
Me.DefaultprojectidLabel.Size = New System.Drawing.Size(129, 16)
Me.DefaultprojectidLabel.Visible=True
me.DefaultprojectidLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.DefaultprojectidLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.DefaultprojectidLabel.Text = "Default Project"


Me.DefaultCompany.Name = "DefaultCompany"
Me.DefaultCompany.Location = New System.Drawing.Point(539, 243)
Me.DefaultCompany.Size = New System.Drawing.Size(239, 16)
Me.DefaultCompany.Visible=False
me.DefaultCompany.TabIndex = 12
me.DefaultCompany.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.DefaultCompany.RowSourceType = "Table/Query"
me.DefaultCompany.RowSource = "vCoCompany"

Me.DefaultCompanyLabel.Name = "DefaultCompanyLabel"
Me.DefaultCompanyLabel.Location = New System.Drawing.Point(405, 243)
Me.DefaultCompanyLabel.Size = New System.Drawing.Size(129, 16)
Me.DefaultCompanyLabel.Visible=True
me.DefaultCompanyLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.DefaultCompanyLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.DefaultCompanyLabel.Text = "Default Co/Company"


Me.Tab13th.Name = "Tab13th"
Me.Tab13th.Location = New System.Drawing.Point(9, 33)
Me.Tab13th.Size = New System.Drawing.Size(786, 354)
Me.Tab13th.Visible=True
Me.Tab13th.Text = "Annual Leave"

Me.ReleaseddateHelpLabel.Name = "ReleaseddateHelpLabel"
Me.ReleaseddateHelpLabel.Location = New System.Drawing.Point(395, 114)
Me.ReleaseddateHelpLabel.Size = New System.Drawing.Size(388, 29)
Me.ReleaseddateHelpLabel.Visible=True
me.ReleaseddateHelpLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.ReleaseddateHelpLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft
Me.ReleaseddateHelpLabel.Text = "The Terminarion date must be ON or AFTER the latest paid date of this employee."


Me.AvailableVacationDays.Name = "AvailableVacationDays"
Me.AvailableVacationDays.Location = New System.Drawing.Point(192, 178)
Me.AvailableVacationDays.Size = New System.Drawing.Size(50, 16)
Me.AvailableVacationDays.Visible=True
me.AvailableVacationDays.TabIndex = 0
me.AvailableVacationDays.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.AvailableVacationDays.TextAlign=HorizontalAlignment.Right


Me.AvailableSickDays.Name = "AvailableSickDays"
Me.AvailableSickDays.Location = New System.Drawing.Point(304, 178)
Me.AvailableSickDays.Size = New System.Drawing.Size(50, 16)
Me.AvailableSickDays.Visible=True
me.AvailableSickDays.TabIndex = 1
me.AvailableSickDays.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.AvailableSickDays.TextAlign=HorizontalAlignment.Right


Me.ReleasedDate.Name = "ReleasedDate"
Me.ReleasedDate.Location = New System.Drawing.Point(554, 45)
Me.ReleasedDate.Size = New System.Drawing.Size(75, 16)
Me.ReleasedDate.Visible=True
me.ReleasedDate.TabIndex = 2
me.ReleasedDate.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))

Me.LastworkdateLabel.Name = "LastworkdateLabel"
Me.LastworkdateLabel.Location = New System.Drawing.Point(394, 45)
Me.LastworkdateLabel.Size = New System.Drawing.Size(154, 16)
Me.LastworkdateLabel.Visible=True
me.LastworkdateLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.LastworkdateLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.LastworkdateLabel.Text = "Last Work Date"


Me.TerminationReasonId.Name = "TerminationReasonId"
Me.TerminationReasonId.Location = New System.Drawing.Point(554, 87)
Me.TerminationReasonId.Size = New System.Drawing.Size(206, 16)
Me.TerminationReasonId.Visible=True
me.TerminationReasonId.TabIndex = 3
me.TerminationReasonId.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.TerminationReasonId.RowSourceType = "Table/Query"
me.TerminationReasonId.RowSource = "SELECT EmployeeTerminationReason.TerminationReasonId, EmployeeTerminationReason.TerminationReason FROM EmployeeTerminationReason ORDER BY EmployeeTerminationReason.TerminationReason; "

Me.TerminationReasonLabel.Name = "TerminationReasonLabel"
Me.TerminationReasonLabel.Location = New System.Drawing.Point(394, 87)
Me.TerminationReasonLabel.Size = New System.Drawing.Size(154, 16)
Me.TerminationReasonLabel.Visible=True
me.TerminationReasonLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.TerminationReasonLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.TerminationReasonLabel.Text = "Termination Reason"


Me.TermOptionPayExtraSalaries.Name = "TermOptionPayExtraSalaries"
Me.TermOptionPayExtraSalaries.Location = New System.Drawing.Point(400, 151)
Me.TermOptionPayExtraSalaries.Size = New System.Drawing.Size(14, 14)
Me.TermOptionPayExtraSalaries.Visible=True
me.TermOptionPayExtraSalaries.TabIndex = 4
Me.ChkPayExtraSalariesLabel.Name = "ChkPayExtraSalariesLabel"
Me.ChkPayExtraSalariesLabel.Location = New System.Drawing.Point(415, 149)
Me.ChkPayExtraSalariesLabel.Size = New System.Drawing.Size(325, 28)
Me.ChkPayExtraSalariesLabel.Visible=True
me.ChkPayExtraSalariesLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.ChkPayExtraSalariesLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft
Me.ChkPayExtraSalariesLabel.Text = "Pay extra salaries.  Check here to give extra salaries to the employee at the last paycheck."


Me.TermOptionPaySickDaysOff.Name = "TermOptionPaySickDaysOff"
Me.TermOptionPaySickDaysOff.Location = New System.Drawing.Point(400, 183)
Me.TermOptionPaySickDaysOff.Size = New System.Drawing.Size(14, 14)
Me.TermOptionPaySickDaysOff.Visible=True
me.TermOptionPaySickDaysOff.TabIndex = 5
Me.TermpaydaysoffsickLabel.Name = "TermpaydaysoffsickLabel"
Me.TermpaydaysoffsickLabel.Location = New System.Drawing.Point(415, 181)
Me.TermpaydaysoffsickLabel.Size = New System.Drawing.Size(328, 15)
Me.TermpaydaysoffsickLabel.Visible=True
me.TermpaydaysoffsickLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.TermpaydaysoffsickLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft
Me.TermpaydaysoffsickLabel.Text = "Pay unused Days Off"


Me.Frame244.Name = "Frame244"
Me.Frame244.Location = New System.Drawing.Point(381, 30)
Me.Frame244.Size = New System.Drawing.Size(407, 311)
Me.Frame244.Visible=True
Me.TerminationLabel.Name = "TerminationLabel"
Me.TerminationLabel.Location = New System.Drawing.Point(394, 22)
Me.TerminationLabel.Size = New System.Drawing.Size(155, 16)
Me.TerminationLabel.Visible=True
me.TerminationLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.TerminationLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft
Me.TerminationLabel.Text = "Employment Termination"

Me.TerminationLabel.backcolor = System.Drawing.ColorTranslator.FromOle(-2147483633)

Me.PaidPeriods.Name = "PaidPeriods"
Me.PaidPeriods.Location = New System.Drawing.Point(267, 99)
Me.PaidPeriods.Size = New System.Drawing.Size(54, 17)
Me.PaidPeriods.Visible=True
me.PaidPeriods.TabIndex = 7
me.PaidPeriods.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.PaidPeriods.backcolor =me.backcolor
me.PaidPeriods.ReadOnly = True
Me.PaidPeriods.TextAlign=HorizontalAlignment.Right


Me.PaidPeriodsLabel.Name = "PaidPeriodsLabel"
Me.PaidPeriodsLabel.Location = New System.Drawing.Point(72, 99)
Me.PaidPeriodsLabel.Size = New System.Drawing.Size(185, 16)
Me.PaidPeriodsLabel.Visible=True
me.PaidPeriodsLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.PaidPeriodsLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.PaidPeriodsLabel.Text = "Paid Periods In Year"


Me.PermanentTerninaltionOnlyLabel.Name = "PermanentTerninaltionOnlyLabel"
Me.PermanentTerninaltionOnlyLabel.Location = New System.Drawing.Point(634, 44)
Me.PermanentTerninaltionOnlyLabel.Size = New System.Drawing.Size(152, 17)
Me.PermanentTerninaltionOnlyLabel.Visible=True
me.PermanentTerninaltionOnlyLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.PermanentTerninaltionOnlyLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft
Me.PermanentTerninaltionOnlyLabel.Text = "Use for permanent termination."


Me.RegularPeriods.Name = "RegularPeriods"
Me.RegularPeriods.Location = New System.Drawing.Point(267, 78)
Me.RegularPeriods.Size = New System.Drawing.Size(54, 17)
Me.RegularPeriods.Visible=True
me.RegularPeriods.TabIndex = 8
me.RegularPeriods.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.RegularPeriods.backcolor =me.backcolor
me.RegularPeriods.ReadOnly = True
Me.RegularPeriods.TextAlign=HorizontalAlignment.Right


Me.YearperiodsLabel.Name = "YearperiodsLabel"
Me.YearperiodsLabel.Location = New System.Drawing.Point(71, 78)
Me.YearperiodsLabel.Size = New System.Drawing.Size(186, 16)
Me.YearperiodsLabel.Visible=True
me.YearperiodsLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.YearperiodsLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.YearperiodsLabel.Text = "Regular Periods In Year"


Me.Lastpaydate.Name = "Lastpaydate"
Me.Lastpaydate.Location = New System.Drawing.Point(554, 66)
Me.Lastpaydate.Size = New System.Drawing.Size(75, 16)
Me.Lastpaydate.Visible=True
me.Lastpaydate.TabIndex = 9
me.Lastpaydate.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Lastpaydate.backcolor =me.backcolor
me.Lastpaydate.ReadOnly = True
Me.Lastpaydate.TextAlign=HorizontalAlignment.Left


Me.LastpaydateLabel.Name = "LastpaydateLabel"
Me.LastpaydateLabel.Location = New System.Drawing.Point(394, 66)
Me.LastpaydateLabel.Size = New System.Drawing.Size(154, 16)
Me.LastpaydateLabel.Visible=True
me.LastpaydateLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.LastpaydateLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.LastpaydateLabel.Text = "Latest Paid Date"


Me.TxtUsedSickDays.Name = "TxtUsedSickDays"
Me.TxtUsedSickDays.Location = New System.Drawing.Point(304, 248)
Me.TxtUsedSickDays.Size = New System.Drawing.Size(50, 16)
Me.TxtUsedSickDays.Visible=True
me.TxtUsedSickDays.TabIndex = 10
me.TxtUsedSickDays.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.TxtUsedSickDays.backcolor =me.backcolor
me.TxtUsedSickDays.ReadOnly = True
Me.TxtUsedSickDays.TextAlign=HorizontalAlignment.Right


Me.AvailableLabel.Name = "AvailableLabel"
Me.AvailableLabel.Location = New System.Drawing.Point(55, 178)
Me.AvailableLabel.Size = New System.Drawing.Size(133, 16)
Me.AvailableLabel.Visible=True
me.AvailableLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.AvailableLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.AvailableLabel.Text = "Available"


Me.TakenLabel.Name = "TakenLabel"
Me.TakenLabel.Location = New System.Drawing.Point(55, 247)
Me.TakenLabel.Size = New System.Drawing.Size(133, 17)
Me.TakenLabel.Visible=True
me.TakenLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.TakenLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.TakenLabel.Text = "Taken To Date"


Me.EarnedVacDaysleftLabel.Name = "EarnedVacDaysleftLabel"
Me.EarnedVacDaysleftLabel.Location = New System.Drawing.Point(31, 269)
Me.EarnedVacDaysleftLabel.Size = New System.Drawing.Size(157, 16)
Me.EarnedVacDaysleftLabel.Visible=True
me.EarnedVacDaysleftLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.EarnedVacDaysleftLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.EarnedVacDaysleftLabel.Text = "EARNED Days Left"


Me.TxtUsedVacationDays.Name = "TxtUsedVacationDays"
Me.TxtUsedVacationDays.Location = New System.Drawing.Point(192, 248)
Me.TxtUsedVacationDays.Size = New System.Drawing.Size(50, 16)
Me.TxtUsedVacationDays.Visible=True
me.TxtUsedVacationDays.TabIndex = 11
me.TxtUsedVacationDays.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.TxtUsedVacationDays.backcolor =me.backcolor
me.TxtUsedVacationDays.ReadOnly = True
Me.TxtUsedVacationDays.TextAlign=HorizontalAlignment.Right


Me.TxtLeftSickDays.Name = "TxtLeftSickDays"
Me.TxtLeftSickDays.Location = New System.Drawing.Point(304, 269)
Me.TxtLeftSickDays.Size = New System.Drawing.Size(50, 16)
Me.TxtLeftSickDays.Visible=True
me.TxtLeftSickDays.TabIndex = 12
me.TxtLeftSickDays.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.TxtLeftSickDays.backcolor =me.backcolor
me.TxtLeftSickDays.ReadOnly = True
Me.TxtLeftSickDays.TextAlign=HorizontalAlignment.Right


Me.TxtLeftVacationDays.Name = "TxtLeftVacationDays"
Me.TxtLeftVacationDays.Location = New System.Drawing.Point(192, 269)
Me.TxtLeftVacationDays.Size = New System.Drawing.Size(50, 16)
Me.TxtLeftVacationDays.Visible=True
me.TxtLeftVacationDays.TabIndex = 13
me.TxtLeftVacationDays.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.TxtLeftVacationDays.backcolor =me.backcolor
me.TxtLeftVacationDays.ReadOnly = True
Me.TxtLeftVacationDays.TextAlign=HorizontalAlignment.Right


Me.TxtTotalFinalExtraPay.Name = "TxtTotalFinalExtraPay"
Me.TxtTotalFinalExtraPay.Location = New System.Drawing.Point(613, 215)
Me.TxtTotalFinalExtraPay.Size = New System.Drawing.Size(99, 16)
Me.TxtTotalFinalExtraPay.Visible=False
me.TxtTotalFinalExtraPay.TabIndex = 14
me.TxtTotalFinalExtraPay.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.TxtTotalFinalExtraPay.backcolor =me.backcolor
me.TxtTotalFinalExtraPay.ReadOnly = True
Me.TxtTotalFinalExtraPay.TextAlign=HorizontalAlignment.Right


Me.TotalFinalExtraPayLabel.Name = "TotalFinalExtraPayLabel"
Me.TotalFinalExtraPayLabel.Location = New System.Drawing.Point(396, 215)
Me.TotalFinalExtraPayLabel.Size = New System.Drawing.Size(211, 16)
Me.TotalFinalExtraPayLabel.Visible=True
me.TotalFinalExtraPayLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.TotalFinalExtraPayLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.TotalFinalExtraPayLabel.Text = "Total Termination Benefits"


Me.TxtEarnedSickDays.Name = "TxtEarnedSickDays"
Me.TxtEarnedSickDays.Location = New System.Drawing.Point(304, 224)
Me.TxtEarnedSickDays.Size = New System.Drawing.Size(50, 16)
Me.TxtEarnedSickDays.Visible=True
me.TxtEarnedSickDays.TabIndex = 15
me.TxtEarnedSickDays.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.TxtEarnedSickDays.backcolor =me.backcolor
me.TxtEarnedSickDays.ReadOnly = True
Me.TxtEarnedSickDays.TextAlign=HorizontalAlignment.Right


Me.EarnedtodateLabel.Name = "EarnedtodateLabel"
Me.EarnedtodateLabel.Location = New System.Drawing.Point(55, 224)
Me.EarnedtodateLabel.Size = New System.Drawing.Size(133, 16)
Me.EarnedtodateLabel.Visible=True
me.EarnedtodateLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.EarnedtodateLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.EarnedtodateLabel.Text = "Earned"


Me.TxtEarnedVacationDays.Name = "TxtEarnedVacationDays"
Me.TxtEarnedVacationDays.Location = New System.Drawing.Point(192, 224)
Me.TxtEarnedVacationDays.Size = New System.Drawing.Size(50, 16)
Me.TxtEarnedVacationDays.Visible=True
me.TxtEarnedVacationDays.TabIndex = 16
me.TxtEarnedVacationDays.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.TxtEarnedVacationDays.backcolor =me.backcolor
me.TxtEarnedVacationDays.ReadOnly = True
Me.TxtEarnedVacationDays.TextAlign=HorizontalAlignment.Right


Me.AvailableSickDaysLabel.Name = "AvailableSickDaysLabel"
Me.AvailableSickDaysLabel.Location = New System.Drawing.Point(244, 148)
Me.AvailableSickDaysLabel.Size = New System.Drawing.Size(110, 28)
Me.AvailableSickDaysLabel.Visible=True
me.AvailableSickDaysLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.AvailableSickDaysLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.AvailableSickDaysLabel.Text = "Available Sick Days"


Me.AvailableVacationHoursLabel.Name = "AvailableVacationHoursLabel"
Me.AvailableVacationHoursLabel.Location = New System.Drawing.Point(132, 148)
Me.AvailableVacationHoursLabel.Size = New System.Drawing.Size(110, 28)
Me.AvailableVacationHoursLabel.Visible=True
me.AvailableVacationHoursLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.AvailableVacationHoursLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.AvailableVacationHoursLabel.Text = "Available Vacation Days"


Me.Paidportion.Name = "Paidportion"
Me.Paidportion.Location = New System.Drawing.Point(267, 121)
Me.Paidportion.Size = New System.Drawing.Size(54, 17)
Me.Paidportion.Visible=True
me.Paidportion.TabIndex = 17
me.Paidportion.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Paidportion.backcolor =me.backcolor
me.Paidportion.ReadOnly = True
Me.Paidportion.TextAlign=HorizontalAlignment.Right


Me.PaidportionLabel.Name = "PaidportionLabel"
Me.PaidportionLabel.Location = New System.Drawing.Point(71, 121)
Me.PaidportionLabel.Size = New System.Drawing.Size(185, 16)
Me.PaidportionLabel.Visible=True
me.PaidportionLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.PaidportionLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.PaidportionLabel.Text = "Year Paid %"


Me.CmdNextYear.Name = "CmdNextYear"
Me.CmdNextYear.Location = New System.Drawing.Point(289, 45)
Me.CmdNextYear.Size = New System.Drawing.Size(20, 16)
Me.CmdNextYear.Visible=True
me.CmdNextYear.TabIndex = 18
me.CmdNextYear.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.CmdNextYear.Text = ""
Me.CmdPreviousYear.Name = "CmdPreviousYear"
Me.CmdPreviousYear.Location = New System.Drawing.Point(209, 45)
Me.CmdPreviousYear.Size = New System.Drawing.Size(20, 16)
Me.CmdPreviousYear.Visible=True
me.CmdPreviousYear.TabIndex = 19
me.CmdPreviousYear.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.CmdPreviousYear.Text = ""
Me.PayyearLabel.Name = "PayyearLabel"
Me.PayyearLabel.Location = New System.Drawing.Point(95, 45)
Me.PayyearLabel.Size = New System.Drawing.Size(109, 16)
Me.PayyearLabel.Visible=True
me.PayyearLabel.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.PayyearLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.PayyearLabel.Text = "Payroll Year"

Me.PayyearLabel.forecolor = System.Drawing.ColorTranslator.FromOle(-2147483630)

Me.Filteryear.Name = "Filteryear"
Me.Filteryear.Location = New System.Drawing.Point(231, 45)
Me.Filteryear.Size = New System.Drawing.Size(55, 16)
Me.Filteryear.Visible=True
me.Filteryear.TabIndex = 20
me.Filteryear.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Filteryear.ReadOnly = True
Me.Filteryear.TextAlign=HorizontalAlignment.center


Me.Frame335.Name = "Frame335"
Me.Frame335.Location = New System.Drawing.Point(21, 30)
Me.Frame335.Size = New System.Drawing.Size(356, 311)
Me.Frame335.Visible=True
Me.VacationdaysStmtLabel.Name = "VacationdaysStmtLabel"
Me.VacationdaysStmtLabel.Location = New System.Drawing.Point(34, 21)
Me.VacationdaysStmtLabel.Size = New System.Drawing.Size(103, 16)
Me.VacationdaysStmtLabel.Visible=True
me.VacationdaysStmtLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.VacationdaysStmtLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft
Me.VacationdaysStmtLabel.Text = "Vacation Days"

Me.VacationdaysStmtLabel.backcolor = System.Drawing.ColorTranslator.FromOle(-2147483633)

Me.LeftLabel1.Name = "LeftLabel1"
Me.LeftLabel1.Location = New System.Drawing.Point(27, 293)
Me.LeftLabel1.Size = New System.Drawing.Size(161, 16)
Me.LeftLabel1.Visible=True
me.LeftLabel1.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.LeftLabel1.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.LeftLabel1.Text = "Remaining"


Me.TxtLeftSickDaysPrev.Name = "TxtLeftSickDaysPrev"
Me.TxtLeftSickDaysPrev.Location = New System.Drawing.Point(304, 293)
Me.TxtLeftSickDaysPrev.Size = New System.Drawing.Size(50, 16)
Me.TxtLeftSickDaysPrev.Visible=False
me.TxtLeftSickDaysPrev.TabIndex = 22
me.TxtLeftSickDaysPrev.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.TxtLeftSickDaysPrev.backcolor =me.backcolor
me.TxtLeftSickDaysPrev.ReadOnly = True
Me.TxtLeftSickDaysPrev.TextAlign=HorizontalAlignment.Right


Me.TxtLeftVacationDaysPrev.Name = "TxtLeftVacationDaysPrev"
Me.TxtLeftVacationDaysPrev.Location = New System.Drawing.Point(192, 293)
Me.TxtLeftVacationDaysPrev.Size = New System.Drawing.Size(50, 16)
Me.TxtLeftVacationDaysPrev.Visible=True
me.TxtLeftVacationDaysPrev.TabIndex = 23
me.TxtLeftVacationDaysPrev.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.TxtLeftVacationDaysPrev.backcolor =me.backcolor
me.TxtLeftVacationDaysPrev.ReadOnly = True
Me.TxtLeftVacationDaysPrev.TextAlign=HorizontalAlignment.Right


Me.TransferredDaysoff.Name = "TransferredDaysoff"
Me.TransferredDaysoff.Location = New System.Drawing.Point(192, 201)
Me.TransferredDaysoff.Size = New System.Drawing.Size(50, 16)
Me.TransferredDaysoff.Visible=True
me.TransferredDaysoff.TabIndex = 24
me.TransferredDaysoff.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.TransferredDaysoff.TextAlign=HorizontalAlignment.Right


Me.TransferredDaysoffLabel.Name = "TransferredDaysoffLabel"
Me.TransferredDaysoffLabel.Location = New System.Drawing.Point(55, 201)
Me.TransferredDaysoffLabel.Size = New System.Drawing.Size(133, 16)
Me.TransferredDaysoffLabel.Visible=True
me.TransferredDaysoffLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.TransferredDaysoffLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.TransferredDaysoffLabel.Text = "Transferred"


Me.EmplLeaveTypeId.Name = "EmplLeaveTypeId"
Me.EmplLeaveTypeId.Location = New System.Drawing.Point(192, 317)
Me.EmplLeaveTypeId.Size = New System.Drawing.Size(163, 17)
Me.EmplLeaveTypeId.Visible=False
me.EmplLeaveTypeId.TabIndex = 25
me.EmplLeaveTypeId.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.EmplLeaveTypeId.RowSourceType = "Table/Query"
me.EmplLeaveTypeId.RowSource = "EmployeeAnnualLeaveType"

Me.EmployeeAnnualLeaveTypeLabel.Name = "EmployeeAnnualLeaveTypeLabel"
Me.EmployeeAnnualLeaveTypeLabel.Location = New System.Drawing.Point(30, 317)
Me.EmployeeAnnualLeaveTypeLabel.Size = New System.Drawing.Size(158, 16)
Me.EmployeeAnnualLeaveTypeLabel.Visible=True
me.EmployeeAnnualLeaveTypeLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.EmployeeAnnualLeaveTypeLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.EmployeeAnnualLeaveTypeLabel.Text = "Annual Leave Type"


Me.PgAccounting.Name = "PgAccounting"
Me.PgAccounting.Location = New System.Drawing.Point(9, 33)
Me.PgAccounting.Size = New System.Drawing.Size(786, 354)
Me.PgAccounting.Visible=True
Me.PgAccounting.Text = "Accounting"

Me.EmplAccTypeId.Name = "EmplAccTypeId"
Me.EmplAccTypeId.Location = New System.Drawing.Point(267, 12)
Me.EmplAccTypeId.Size = New System.Drawing.Size(195, 17)
Me.EmplAccTypeId.Visible=True
me.EmplAccTypeId.TabIndex = 0
me.EmplAccTypeId.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.EmplAccTypeId.RowSourceType = "Table/Query"
me.EmplAccTypeId.RowSource = "SELECT EmployeeAccType.EmplAccTypeId, EmployeeAccType.EmplAccTypeName FROM EmployeeAccType ORDER BY EmployeeAccType.EmplAccTypeName; "

Me.EmplAccTypeLabel.Name = "EmplAccTypeLabel"
Me.EmplAccTypeLabel.Location = New System.Drawing.Point(57, 12)
Me.EmplAccTypeLabel.Size = New System.Drawing.Size(209, 16)
Me.EmplAccTypeLabel.Visible=True
me.EmplAccTypeLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.EmplAccTypeLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.EmplAccTypeLabel.Text = "Accounting Category"


Me.PaymentAccountIDHelpLabel.Name = "PaymentAccountIDHelpLabel"
Me.PaymentAccountIDHelpLabel.Location = New System.Drawing.Point(470, 41)
Me.PaymentAccountIDHelpLabel.Size = New System.Drawing.Size(324, 43)
Me.PaymentAccountIDHelpLabel.Visible=True
me.PaymentAccountIDHelpLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.PaymentAccountIDHelpLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft
Me.PaymentAccountIDHelpLabel.Text = "Account to credit the net employee salary. For example, the bank account of your company"


Me.PaymentAccountID.Name = "PaymentAccountID"
Me.PaymentAccountID.Location = New System.Drawing.Point(267, 40)
Me.PaymentAccountID.Size = New System.Drawing.Size(195, 17)
Me.PaymentAccountID.Visible=True
me.PaymentAccountID.TabIndex = 1
me.PaymentAccountID.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.PaymentAccountID.RowSourceType = "Table/Query"
me.PaymentAccountID.RowSource = "vPickListAccounts"

Me.PaymentAccountIDLabel.Name = "PaymentAccountIDLabel"
Me.PaymentAccountIDLabel.Location = New System.Drawing.Point(57, 40)
Me.PaymentAccountIDLabel.Size = New System.Drawing.Size(209, 17)
Me.PaymentAccountIDLabel.Visible=True
me.PaymentAccountIDLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.PaymentAccountIDLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.PaymentAccountIDLabel.Text = "Payment Account"


Me.Frame309.Name = "Frame309"
Me.Frame309.Location = New System.Drawing.Point(70, 272)
Me.Frame309.Size = New System.Drawing.Size(686, 60)
Me.Frame309.Visible=True
Me.EmplOverheadLabel.Name = "EmplOverheadLabel"
Me.EmplOverheadLabel.Location = New System.Drawing.Point(80, 265)
Me.EmplOverheadLabel.Size = New System.Drawing.Size(149, 18)
Me.EmplOverheadLabel.Visible=True
me.EmplOverheadLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.EmplOverheadLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft
Me.EmplOverheadLabel.Text = "Fixed Costs (Overheads)"

Me.EmplOverheadLabel.backcolor = System.Drawing.ColorTranslator.FromOle(-2147483633)

Me.PayMethodID.Name = "PayMethodID"
Me.PayMethodID.Location = New System.Drawing.Point(267, 87)
Me.PayMethodID.Size = New System.Drawing.Size(195, 16)
Me.PayMethodID.Visible=True
me.PayMethodID.TabIndex = 3
me.PayMethodID.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.PayMethodID.RowSourceType = "Table/Query"
me.PayMethodID.RowSource = "vEmployeePayMethod"

Me.PaymethodLabel.Name = "PaymethodLabel"
Me.PaymethodLabel.Location = New System.Drawing.Point(57, 87)
Me.PaymethodLabel.Size = New System.Drawing.Size(209, 16)
Me.PaymethodLabel.Visible=True
me.PaymethodLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.PaymethodLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.PaymethodLabel.Text = "Payment Method"


Me.OhEmployeeCostHelpLabel.Name = "OhEmployeeCostHelpLabel"
Me.OhEmployeeCostHelpLabel.Location = New System.Drawing.Point(322, 309)
Me.OhEmployeeCostHelpLabel.Size = New System.Drawing.Size(230, 16)
Me.OhEmployeeCostHelpLabel.Visible=True
me.OhEmployeeCostHelpLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.OhEmployeeCostHelpLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft
Me.OhEmployeeCostHelpLabel.Text = "For example, employee insurance costs"


Me.OhHiringCostHelpLabel.Name = "OhHiringCostHelpLabel"
Me.OhHiringCostHelpLabel.Location = New System.Drawing.Point(322, 287)
Me.OhHiringCostHelpLabel.Size = New System.Drawing.Size(426, 16)
Me.OhHiringCostHelpLabel.Visible=True
me.OhHiringCostHelpLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.OhHiringCostHelpLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft
Me.OhHiringCostHelpLabel.Text = "Initial Employee Hiring costs"


Me.BankAccNumber.Name = "BankAccNumber"
Me.BankAccNumber.Location = New System.Drawing.Point(267, 107)
Me.BankAccNumber.Size = New System.Drawing.Size(195, 16)
Me.BankAccNumber.Visible=True
me.BankAccNumber.TabIndex = 4
me.BankAccNumber.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.BankAccNumber.TextAlign=HorizontalAlignment.Left


Me.BankAccNumberLabel.Name = "BankAccNumberLabel"
Me.BankAccNumberLabel.Location = New System.Drawing.Point(57, 107)
Me.BankAccNumberLabel.Size = New System.Drawing.Size(209, 16)
Me.BankAccNumberLabel.Visible=True
me.BankAccNumberLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.BankAccNumberLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.BankAccNumberLabel.Text = "Bank Account Number"


Me.BankAccountIBANCode.Name = "BankAccountIBANCode"
Me.BankAccountIBANCode.Location = New System.Drawing.Point(267, 127)
Me.BankAccountIBANCode.Size = New System.Drawing.Size(195, 16)
Me.BankAccountIBANCode.Visible=True
me.BankAccountIBANCode.TabIndex = 5
me.BankAccountIBANCode.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.BankAccountIBANCode.TextAlign=HorizontalAlignment.Left


Me.BankAccountIBANCodeLabel.Name = "BankAccountIBANCodeLabel"
Me.BankAccountIBANCodeLabel.Location = New System.Drawing.Point(57, 127)
Me.BankAccountIBANCodeLabel.Size = New System.Drawing.Size(209, 16)
Me.BankAccountIBANCodeLabel.Visible=True
me.BankAccountIBANCodeLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.BankAccountIBANCodeLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.BankAccountIBANCodeLabel.Text = "Account IBAN Number"


Me.BankId.Name = "BankId"
Me.BankId.Location = New System.Drawing.Point(267, 146)
Me.BankId.Size = New System.Drawing.Size(195, 16)
Me.BankId.Visible=True
me.BankId.TabIndex = 6
me.BankId.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.BankId.RowSourceType = "Table/Query"
me.BankId.RowSource = "SELECT 0 as BANKID, '< Select >' as BankName, null as BankCode, null as BankSWIFTCode FROM Bank AS b union SELECT b.BANKID, b.BankName, b.BankCode, b.BankSWIFTCode FROM Bank AS b order by 2"

Me.BankIdLabel.Name = "BankIdLabel"
Me.BankIdLabel.Location = New System.Drawing.Point(57, 146)
Me.BankIdLabel.Size = New System.Drawing.Size(209, 16)
Me.BankIdLabel.Visible=True
me.BankIdLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.BankIdLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.BankIdLabel.Text = "Bank"


Me.EmplAccountBankSWIFTCode.Name = "EmplAccountBankSWIFTCode"
Me.EmplAccountBankSWIFTCode.Location = New System.Drawing.Point(267, 166)
Me.EmplAccountBankSWIFTCode.Size = New System.Drawing.Size(195, 16)
Me.EmplAccountBankSWIFTCode.Visible=True
me.EmplAccountBankSWIFTCode.TabIndex = 7
me.EmplAccountBankSWIFTCode.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.EmplAccountBankSWIFTCode.TextAlign=HorizontalAlignment.Left


Me.BankSWIFTCodeLabel.Name = "BankSWIFTCodeLabel"
Me.BankSWIFTCodeLabel.Location = New System.Drawing.Point(57, 166)
Me.BankSWIFTCodeLabel.Size = New System.Drawing.Size(209, 16)
Me.BankSWIFTCodeLabel.Visible=True
me.BankSWIFTCodeLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.BankSWIFTCodeLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.BankSWIFTCodeLabel.Text = "SWIFT Code"


Me.BankBeneficiaryName.Name = "BankBeneficiaryName"
Me.BankBeneficiaryName.Location = New System.Drawing.Point(267, 186)
Me.BankBeneficiaryName.Size = New System.Drawing.Size(195, 16)
Me.BankBeneficiaryName.Visible=True
me.BankBeneficiaryName.TabIndex = 8
me.BankBeneficiaryName.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.BankBeneficiaryName.TextAlign=HorizontalAlignment.Left


Me.BankBeneficiaryNameLabel.Name = "BankBeneficiaryNameLabel"
Me.BankBeneficiaryNameLabel.Location = New System.Drawing.Point(57, 186)
Me.BankBeneficiaryNameLabel.Size = New System.Drawing.Size(209, 16)
Me.BankBeneficiaryNameLabel.Visible=True
me.BankBeneficiaryNameLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.BankBeneficiaryNameLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.BankBeneficiaryNameLabel.Text = "Account Beneficiary Name"


Me.BankBeneficiaryIdCode.Name = "BankBeneficiaryIdCode"
Me.BankBeneficiaryIdCode.Location = New System.Drawing.Point(267, 205)
Me.BankBeneficiaryIdCode.Size = New System.Drawing.Size(195, 16)
Me.BankBeneficiaryIdCode.Visible=True
me.BankBeneficiaryIdCode.TabIndex = 9
me.BankBeneficiaryIdCode.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.BankBeneficiaryIdCode.TextAlign=HorizontalAlignment.Left


Me.BankBeneficiaryIdCodeLabel.Name = "BankBeneficiaryIdCodeLabel"
Me.BankBeneficiaryIdCodeLabel.Location = New System.Drawing.Point(57, 205)
Me.BankBeneficiaryIdCodeLabel.Size = New System.Drawing.Size(209, 16)
Me.BankBeneficiaryIdCodeLabel.Visible=True
me.BankBeneficiaryIdCodeLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.BankBeneficiaryIdCodeLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.BankBeneficiaryIdCodeLabel.Text = "Beneficiary Id Number"


Me.NoPayForExtraHours.Name = "NoPayForExtraHours"
Me.NoPayForExtraHours.Location = New System.Drawing.Point(80, 229)
Me.NoPayForExtraHours.Size = New System.Drawing.Size(14, 14)
Me.NoPayForExtraHours.Visible=True
me.NoPayForExtraHours.TabIndex = 10
Me.NoPayForExtraHoursLabel.Name = "NoPayForExtraHoursLabel"
Me.NoPayForExtraHoursLabel.Location = New System.Drawing.Point(95, 227)
Me.NoPayForExtraHoursLabel.Size = New System.Drawing.Size(433, 16)
Me.NoPayForExtraHoursLabel.Visible=True
me.NoPayForExtraHoursLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.NoPayForExtraHoursLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft
Me.NoPayForExtraHoursLabel.Text = "Don't pay extra hours if work hours exceed regular hours in period"


Me.BankBenNmHelp.Name = "BankBenNmHelp"
Me.BankBenNmHelp.Location = New System.Drawing.Point(468, 188)
Me.BankBenNmHelp.Size = New System.Drawing.Size(261, 16)
Me.BankBenNmHelp.Visible=True
me.BankBenNmHelp.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.BankBenNmHelp.TextAlign=System.Drawing.ContentAlignment.MiddleLeft
Me.BankBenNmHelp.Text = "If different from Employee name"


Me.NoDeductionForLessHours.Name = "NoDeductionForLessHours"
Me.NoDeductionForLessHours.Location = New System.Drawing.Point(80, 248)
Me.NoDeductionForLessHours.Size = New System.Drawing.Size(14, 14)
Me.NoDeductionForLessHours.Visible=True
me.NoDeductionForLessHours.TabIndex = 11
Me.NoDeductionForLessHoursLabel.Name = "NoDeductionForLessHoursLabel"
Me.NoDeductionForLessHoursLabel.Location = New System.Drawing.Point(95, 246)
Me.NoDeductionForLessHoursLabel.Size = New System.Drawing.Size(465, 16)
Me.NoDeductionForLessHoursLabel.Visible=True
me.NoDeductionForLessHoursLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.NoDeductionForLessHoursLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft
Me.NoDeductionForLessHoursLabel.Text = "Don't deduct salary if work hours are less that the hours in period."


Me.OhHiringCost.Name = "OhHiringCost"
Me.OhHiringCost.Location = New System.Drawing.Point(242, 287)
Me.OhHiringCost.Size = New System.Drawing.Size(74, 16)
Me.OhHiringCost.Visible=True
me.OhHiringCost.TabIndex = 12
me.OhHiringCost.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.OhHiringCost.TextAlign=HorizontalAlignment.Right


Me.EmplOhHiringCosts.Name = "EmplOhHiringCosts"
Me.EmplOhHiringCosts.Location = New System.Drawing.Point(87, 287)
Me.EmplOhHiringCosts.Size = New System.Drawing.Size(137, 16)
Me.EmplOhHiringCosts.Visible=True
me.EmplOhHiringCosts.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.EmplOhHiringCosts.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.EmplOhHiringCosts.Text = "Initial Employment Cost"


Me.OhEmployeeCost.Name = "OhEmployeeCost"
Me.OhEmployeeCost.Location = New System.Drawing.Point(242, 308)
Me.OhEmployeeCost.Size = New System.Drawing.Size(74, 16)
Me.OhEmployeeCost.Visible=True
me.OhEmployeeCost.TabIndex = 13
me.OhEmployeeCost.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.OhEmployeeCost.TextAlign=HorizontalAlignment.Right


Me.EmplOhYearlyCosts.Name = "EmplOhYearlyCosts"
Me.EmplOhYearlyCosts.Location = New System.Drawing.Point(87, 308)
Me.EmplOhYearlyCosts.Size = New System.Drawing.Size(137, 16)
Me.EmplOhYearlyCosts.Visible=True
me.EmplOhYearlyCosts.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.EmplOhYearlyCosts.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.EmplOhYearlyCosts.Text = "Fixed Annual Costs"


Me.HrinfoLabel.Name = "HrinfoLabel"
Me.HrinfoLabel.Location = New System.Drawing.Point(9, 33)
Me.HrinfoLabel.Size = New System.Drawing.Size(786, 354)
Me.HrinfoLabel.Visible=True
Me.HrinfoLabel.Text = "HR"

Me.Rankid.Name = "Rankid"
Me.Rankid.Location = New System.Drawing.Point(171, 24)
Me.Rankid.Size = New System.Drawing.Size(238, 16)
Me.Rankid.Visible=True
me.Rankid.TabIndex = 0
me.Rankid.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Rankid.RowSourceType = "Table/Query"
me.Rankid.RowSource = "EmployeeRank"

Me.RankLabel.Name = "RankLabel"
Me.RankLabel.Location = New System.Drawing.Point(35, 24)
Me.RankLabel.Size = New System.Drawing.Size(128, 16)
Me.RankLabel.Visible=True
me.RankLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.RankLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.RankLabel.Text = "Position"


Me.Departmentid.Name = "Departmentid"
Me.Departmentid.Location = New System.Drawing.Point(171, 49)
Me.Departmentid.Size = New System.Drawing.Size(238, 16)
Me.Departmentid.Visible=True
me.Departmentid.TabIndex = 1
me.Departmentid.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Departmentid.RowSourceType = "Table/Query"
me.Departmentid.RowSource = "vPickListDepartments"

Me.DepartmentLabel.Name = "DepartmentLabel"
Me.DepartmentLabel.Location = New System.Drawing.Point(35, 49)
Me.DepartmentLabel.Size = New System.Drawing.Size(128, 16)
Me.DepartmentLabel.Visible=True
me.DepartmentLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.DepartmentLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.DepartmentLabel.Text = "Department"


Me.ManagerEmplId.Name = "ManagerEmplId"
Me.ManagerEmplId.Location = New System.Drawing.Point(171, 75)
Me.ManagerEmplId.Size = New System.Drawing.Size(238, 16)
Me.ManagerEmplId.Visible=True
me.ManagerEmplId.TabIndex = 2
me.ManagerEmplId.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.ManagerEmplId.RowSourceType = "Table/Query"
me.ManagerEmplId.RowSource = "vPickListEmployee"

Me.ManagerEmplIdLabel.Name = "ManagerEmplIdLabel"
Me.ManagerEmplIdLabel.Location = New System.Drawing.Point(35, 75)
Me.ManagerEmplIdLabel.Size = New System.Drawing.Size(128, 16)
Me.ManagerEmplIdLabel.Visible=True
me.ManagerEmplIdLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.ManagerEmplIdLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.ManagerEmplIdLabel.Text = "Supervisor"


Me.ProbationEndDate.Name = "ProbationEndDate"
Me.ProbationEndDate.Location = New System.Drawing.Point(171, 98)
Me.ProbationEndDate.Size = New System.Drawing.Size(122, 16)
Me.ProbationEndDate.Visible=True
me.ProbationEndDate.TabIndex = 3
me.ProbationEndDate.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))

Me.ProbationEndDateLabel.Name = "ProbationEndDateLabel"
Me.ProbationEndDateLabel.Location = New System.Drawing.Point(14, 98)
Me.ProbationEndDateLabel.Size = New System.Drawing.Size(149, 16)
Me.ProbationEndDateLabel.Visible=True
me.ProbationEndDateLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.ProbationEndDateLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.ProbationEndDateLabel.Text = "Probation End Date"


Me.EmploymentStatusId.Name = "EmploymentStatusId"
Me.EmploymentStatusId.Location = New System.Drawing.Point(534, 24)
Me.EmploymentStatusId.Size = New System.Drawing.Size(206, 16)
Me.EmploymentStatusId.Visible=True
me.EmploymentStatusId.TabIndex = 4
me.EmploymentStatusId.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.EmploymentStatusId.RowSourceType = "Table/Query"
me.EmploymentStatusId.RowSource = "vPickListEmploymentStatus"

Me.EmploymentStatusLabel.Name = "EmploymentStatusLabel"
Me.EmploymentStatusLabel.Location = New System.Drawing.Point(416, 24)
Me.EmploymentStatusLabel.Size = New System.Drawing.Size(111, 16)
Me.EmploymentStatusLabel.Visible=True
me.EmploymentStatusLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.EmploymentStatusLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.EmploymentStatusLabel.Text = "Employment Status"


Me.ForeignIdNumber.Name = "ForeignIdNumber"
Me.ForeignIdNumber.Location = New System.Drawing.Point(534, 49)
Me.ForeignIdNumber.Size = New System.Drawing.Size(206, 16)
Me.ForeignIdNumber.Visible=True
me.ForeignIdNumber.TabIndex = 5
me.ForeignIdNumber.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.ForeignIdNumber.TextAlign=HorizontalAlignment.Left


Me.ForeignIdNumberLabel.Name = "ForeignIdNumberLabel"
Me.ForeignIdNumberLabel.Location = New System.Drawing.Point(416, 49)
Me.ForeignIdNumberLabel.Size = New System.Drawing.Size(111, 16)
Me.ForeignIdNumberLabel.Visible=True
me.ForeignIdNumberLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.ForeignIdNumberLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.ForeignIdNumberLabel.Text = "Foreign Tax Id Number"


Me.Spoucename.Name = "Spoucename"
Me.Spoucename.Location = New System.Drawing.Point(535, 98)
Me.Spoucename.Size = New System.Drawing.Size(171, 16)
Me.Spoucename.Visible=True
me.Spoucename.TabIndex = 6
me.Spoucename.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.Spoucename.TextAlign=HorizontalAlignment.Left


Me.SpoucenameLabel.Name = "SpoucenameLabel"
Me.SpoucenameLabel.Location = New System.Drawing.Point(431, 98)
Me.SpoucenameLabel.Size = New System.Drawing.Size(96, 16)
Me.SpoucenameLabel.Visible=True
me.SpoucenameLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.SpoucenameLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.SpoucenameLabel.Text = "Spouce Name"


Me.WorkDescription.Name = "WorkDescription"
Me.WorkDescription.Location = New System.Drawing.Point(171, 126)
Me.WorkDescription.Size = New System.Drawing.Size(567, 73)
Me.WorkDescription.Visible=True
me.WorkDescription.TabIndex = 7
me.WorkDescription.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.WorkDescription.Multiline = True
Me.WorkDescription.TextAlign=HorizontalAlignment.Left


Me.WorkDescriptionLabel.Name = "WorkDescriptionLabel"
Me.WorkDescriptionLabel.Location = New System.Drawing.Point(35, 126)
Me.WorkDescriptionLabel.Size = New System.Drawing.Size(128, 16)
Me.WorkDescriptionLabel.Visible=True
me.WorkDescriptionLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.WorkDescriptionLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.WorkDescriptionLabel.Text = "Work Description"


Me.HbfileDescription1.Name = "HbfileDescription1"
Me.HbfileDescription1.Location = New System.Drawing.Point(171, 212)
Me.HbfileDescription1.Size = New System.Drawing.Size(206, 16)
Me.HbfileDescription1.Visible=True
me.HbfileDescription1.TabIndex = 8
me.HbfileDescription1.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.HbfileDescription1.TextAlign=HorizontalAlignment.Left


Me.Label413.Name = "Label413"
Me.Label413.Location = New System.Drawing.Point(58, 212)
Me.Label413.Size = New System.Drawing.Size(105, 16)
Me.Label413.Visible=True
me.Label413.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.Label413.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.Label413.Text = "HB File Description 1"


Me.HbfileDescription2.Name = "HbfileDescription2"
Me.HbfileDescription2.Location = New System.Drawing.Point(171, 234)
Me.HbfileDescription2.Size = New System.Drawing.Size(206, 16)
Me.HbfileDescription2.Visible=True
me.HbfileDescription2.TabIndex = 9
me.HbfileDescription2.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.HbfileDescription2.TextAlign=HorizontalAlignment.Left


Me.Label415.Name = "Label415"
Me.Label415.Location = New System.Drawing.Point(58, 234)
Me.Label415.Size = New System.Drawing.Size(105, 16)
Me.Label415.Visible=True
me.Label415.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.Label415.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.Label415.Text = "HB File Description 2"


Me.HbfileDescription3.Name = "HbfileDescription3"
Me.HbfileDescription3.Location = New System.Drawing.Point(171, 258)
Me.HbfileDescription3.Size = New System.Drawing.Size(206, 16)
Me.HbfileDescription3.Visible=True
me.HbfileDescription3.TabIndex = 10
me.HbfileDescription3.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.HbfileDescription3.TextAlign=HorizontalAlignment.Left


Me.Label417.Name = "Label417"
Me.Label417.Location = New System.Drawing.Point(58, 258)
Me.Label417.Size = New System.Drawing.Size(105, 16)
Me.Label417.Visible=True
me.Label417.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.Label417.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.Label417.Text = "HB File Description 3"


Me.Companyid.Name = "Companyid"
Me.Companyid.Location = New System.Drawing.Point(352, 423)
Me.Companyid.Size = New System.Drawing.Size(62, 16)
Me.Companyid.Visible=False
me.Companyid.TabIndex = 15
me.Companyid.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Companyid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.Companyid.TextAlign=HorizontalAlignment.Left


Me.EmployeeNo.Name = "EmployeeNo"
Me.EmployeeNo.Location = New System.Drawing.Point(706, 377)
Me.EmployeeNo.Size = New System.Drawing.Size(49, 13)
Me.EmployeeNo.Visible=True
me.EmployeeNo.TabIndex = 5
me.EmployeeNo.Font = New System.Drawing.Font("Arial", 7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.EmployeeNo.backcolor =me.backcolor
me.EmployeeNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.EmployeeNo.TextAlign=HorizontalAlignment.Left


Me.EmployeeNoLabel.Name = "EmployeeNoLabel"
Me.EmployeeNoLabel.Location = New System.Drawing.Point(600, 377)
Me.EmployeeNoLabel.Size = New System.Drawing.Size(106, 13)
Me.EmployeeNoLabel.Visible=True
me.EmployeeNoLabel.Font = New System.Drawing.Font("Arial", 7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.EmployeeNoLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.EmployeeNoLabel.Text = "Employee No"


Me.Createuser.Name = "Createuser"
Me.Createuser.Location = New System.Drawing.Point(352, 404)
Me.Createuser.Size = New System.Drawing.Size(47, 16)
Me.Createuser.Visible=False
me.Createuser.TabIndex = 14
me.Createuser.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Createuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.Createuser.TextAlign=HorizontalAlignment.Left


Me.Updateuser.Name = "Updateuser"
Me.Updateuser.Location = New System.Drawing.Point(476, 400)
Me.Updateuser.Size = New System.Drawing.Size(47, 16)
Me.Updateuser.Visible=False
me.Updateuser.TabIndex = 13
me.Updateuser.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Updateuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.Updateuser.TextAlign=HorizontalAlignment.Left


Me.CmdDelete.Name = "CmdDelete"
Me.CmdDelete.Location = New System.Drawing.Point(5, 403)
Me.CmdDelete.Size = New System.Drawing.Size(43, 33)
Me.CmdDelete.Visible=True
me.CmdDelete.TabIndex = 6
me.CmdDelete.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.CmdDelete.Text = "Delete"
Me.CmdReviewReport.Name = "CmdReviewReport"
Me.CmdReviewReport.Location = New System.Drawing.Point(55, 403)
Me.CmdReviewReport.Size = New System.Drawing.Size(43, 33)
Me.CmdReviewReport.Visible=True
me.CmdReviewReport.TabIndex = 7
me.CmdReviewReport.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.CmdReviewReport.Text = ""
Me.CmdPrintSocIns.Name = "CmdPrintSocIns"
Me.CmdPrintSocIns.Location = New System.Drawing.Point(104, 403)
Me.CmdPrintSocIns.Size = New System.Drawing.Size(109, 33)
Me.CmdPrintSocIns.Visible=True
me.CmdPrintSocIns.TabIndex = 8
me.CmdPrintSocIns.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.CmdPrintSocIns.Text = "EMPLOYEES ENROLLMENT FORM"
Me.CmdPrintSocIns.forecolor = System.Drawing.ColorTranslator.FromOle(-2147483630)
Me.CmdSave.Name = "CmdSave"
Me.CmdSave.Location = New System.Drawing.Point(720, 403)
Me.CmdSave.Size = New System.Drawing.Size(82, 33)
Me.CmdSave.Visible=True
me.CmdSave.TabIndex = 12
me.CmdSave.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.CmdSave.Text = "Save"
Me.CmdSave.forecolor = System.Drawing.ColorTranslator.FromOle(4210816)
Me.CmdClose.Name = "CmdClose"
Me.CmdClose.Location = New System.Drawing.Point(624, 403)
Me.CmdClose.Size = New System.Drawing.Size(92, 33)
Me.CmdClose.Visible=True
me.CmdClose.TabIndex = 11
me.CmdClose.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.CmdClose.Text = "&Close"
Me.CmdClose.forecolor = System.Drawing.ColorTranslator.FromOle(-2147483630)
Me.CmdIncomeTax.Name = "CmdIncomeTax"
Me.CmdIncomeTax.Location = New System.Drawing.Point(218, 403)
Me.CmdIncomeTax.Size = New System.Drawing.Size(79, 33)
Me.CmdIncomeTax.Visible=True
me.CmdIncomeTax.TabIndex = 9
me.CmdIncomeTax.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.CmdIncomeTax.Text = "IR 59"
Me.CmdIncomeTax.forecolor = System.Drawing.ColorTranslator.FromOle(-2147483630)
Me.Employeeid.Name = "Employeeid"
Me.Employeeid.Location = New System.Drawing.Point(417, 403)
Me.Employeeid.Size = New System.Drawing.Size(55, 17)
Me.Employeeid.Visible=False
me.Employeeid.TabIndex = 10
me.Employeeid.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Employeeid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.Employeeid.TextAlign=HorizontalAlignment.Left


Me.Createdate.Name = "Createdate"
Me.Createdate.Location = New System.Drawing.Point(60, 377)
Me.Createdate.Size = New System.Drawing.Size(90, 13)
Me.Createdate.Visible=True
me.Createdate.TabIndex = 3
me.Createdate.Font = New System.Drawing.Font("Arial", 7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Createdate.backcolor =me.backcolor
me.Createdate.ReadOnly = True
me.Createdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.Createdate.TextAlign=HorizontalAlignment.Left


Me.CreatedateShortLabel.Name = "CreatedateShortLabel"
Me.CreatedateShortLabel.Location = New System.Drawing.Point(13, 377)
Me.CreatedateShortLabel.Size = New System.Drawing.Size(47, 13)
Me.CreatedateShortLabel.Visible=True
me.CreatedateShortLabel.Font = New System.Drawing.Font("Arial", 7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.CreatedateShortLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.CreatedateShortLabel.Text = "Created"


Me.Updatedate.Name = "Updatedate"
Me.Updatedate.Location = New System.Drawing.Point(194, 377)
Me.Updatedate.Size = New System.Drawing.Size(100, 13)
Me.Updatedate.Visible=True
me.Updatedate.TabIndex = 4
me.Updatedate.Font = New System.Drawing.Font("Arial", 7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Updatedate.backcolor =me.backcolor
me.Updatedate.ReadOnly = True
me.Updatedate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.Updatedate.TextAlign=HorizontalAlignment.Left


Me.UpdatedShortLabel.Name = "UpdatedShortLabel"
Me.UpdatedShortLabel.Location = New System.Drawing.Point(150, 377)
Me.UpdatedShortLabel.Size = New System.Drawing.Size(44, 13)
Me.UpdatedShortLabel.Visible=True
me.UpdatedShortLabel.Font = New System.Drawing.Font("Arial", 7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.UpdatedShortLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.UpdatedShortLabel.Text = "Updated"


Me.CmdNext.Name = "CmdNext"
Me.CmdNext.Location = New System.Drawing.Point(760, 26)
Me.CmdNext.Size = New System.Drawing.Size(20, 18)
Me.CmdNext.Visible=True
me.CmdNext.TabIndex = 2
me.CmdNext.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.CmdNext.Text = "Next"
Me.CmdNext.forecolor = System.Drawing.ColorTranslator.FromOle(-2147483630)
Me.CmdPrev.Name = "CmdPrev"
Me.CmdPrev.Location = New System.Drawing.Point(738, 26)
Me.CmdPrev.Size = New System.Drawing.Size(20, 18)
Me.CmdPrev.Visible=True
me.CmdPrev.TabIndex = 1
me.CmdPrev.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.CmdPrev.Text = "Previous"
Me.CmdPrev.forecolor = System.Drawing.ColorTranslator.FromOle(-2147483630)
Me.CmdCopy.Name = "CmdCopy"
Me.CmdCopy.Location = New System.Drawing.Point(525, 403)
Me.CmdCopy.Size = New System.Drawing.Size(92, 33)
Me.CmdCopy.Visible=True
me.CmdCopy.TabIndex = 16
me.CmdCopy.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.CmdCopy.Text = "&Save As..."
Me.CmdCopy.forecolor = System.Drawing.ColorTranslator.FromOle(-2147483630)
       
		
		Me.ErrProvider.ContainerControl = Me
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        
        
Me.controls.add(me.TbEmployee)
TbEmployee.controls.add(me.PgEmployeeInfo)
PgEmployeeInfo.controls.add(me.Salutation)
PgEmployeeInfo.controls.add(me.FirstName)
PgEmployeeInfo.controls.add(me.FirstNameLabel)
PgEmployeeInfo.controls.add(me.MiddleName)
PgEmployeeInfo.controls.add(me.MiddleNameLabel)
PgEmployeeInfo.controls.add(me.LastName)
PgEmployeeInfo.controls.add(me.LastNameLabel)
PgEmployeeInfo.controls.add(me.QuickBooksName)
PgEmployeeInfo.controls.add(me.QuickBooksNameLabel)
PgEmployeeInfo.controls.add(me.EmployeeAddressAddr1)
PgEmployeeInfo.controls.add(me.Addr1Label)
PgEmployeeInfo.controls.add(me.EmployeeAddressAddr2)
PgEmployeeInfo.controls.add(me.EmployeeAddressCity)
PgEmployeeInfo.controls.add(me.CityLabel)
PgEmployeeInfo.controls.add(me.EmployeeAddressState)
PgEmployeeInfo.controls.add(me.StateLabel)
PgEmployeeInfo.controls.add(me.EmployeeAddressPostalCode)
PgEmployeeInfo.controls.add(me.PostalCodeLabel)
PgEmployeeInfo.controls.add(me.EmployeeAddressCountry)
PgEmployeeInfo.controls.add(me.CountryLabel)
PgEmployeeInfo.controls.add(me.Telephone)
PgEmployeeInfo.controls.add(me.PhoneLabel)
PgEmployeeInfo.controls.add(me.MobilePhone)
PgEmployeeInfo.controls.add(me.MobilePhoneLabel)
PgEmployeeInfo.controls.add(me.Telephone2)
PgEmployeeInfo.controls.add(me.Telephone2Label)
PgEmployeeInfo.controls.add(me.Email)
PgEmployeeInfo.controls.add(me.EmailLabel)
PgEmployeeInfo.controls.add(me.Genderid)
PgEmployeeInfo.controls.add(me.GenderidLabel)
PgEmployeeInfo.controls.add(me.HiredDate)
PgEmployeeInfo.controls.add(me.HiredDateLabel)
PgEmployeeInfo.controls.add(me.CmdCalHireddate)
PgEmployeeInfo.controls.add(me.SocialInsuranceNumber)
PgEmployeeInfo.controls.add(me.SocialInsuranceNumberLabel)
PgEmployeeInfo.controls.add(me.Cyprusidnumber)
PgEmployeeInfo.controls.add(me.CyprusidnumberLabel)
PgEmployeeInfo.controls.add(me.PayFrequencyID)
PgEmployeeInfo.controls.add(me.PayFrequencyIDLabel)
PgEmployeeInfo.controls.add(me.Dateofbirth)
PgEmployeeInfo.controls.add(me.DateofbirthLabel)
PgEmployeeInfo.controls.add(me.CmdCalDateofbirth)
PgEmployeeInfo.controls.add(me.Placeofbirth)
PgEmployeeInfo.controls.add(me.PlaceofbirthLabel)
PgEmployeeInfo.controls.add(me.Maritalstatus)
PgEmployeeInfo.controls.add(me.MaritalstatusLabel)
PgEmployeeInfo.controls.add(me.Professionid)
PgEmployeeInfo.controls.add(me.ProfessionLabel)
PgEmployeeInfo.controls.add(me.AlienIDNumber)
PgEmployeeInfo.controls.add(me.AlienIDNumberLabel)
PgEmployeeInfo.controls.add(me.PassportNumber)
PgEmployeeInfo.controls.add(me.PassportNumberLabel)
PgEmployeeInfo.controls.add(me.SocinsCategoryid)
PgEmployeeInfo.controls.add(me.SocinsCategoryLabel)
PgEmployeeInfo.controls.add(me.Ssicommunityid)
PgEmployeeInfo.controls.add(me.SsicommunityidLabel)
PgEmployeeInfo.controls.add(me.DriverLicenceNo)
PgEmployeeInfo.controls.add(me.DriverLicenceNoLabel)
PgEmployeeInfo.controls.add(me.ITaxIdNumber)
PgEmployeeInfo.controls.add(me.ITaxIdNumberLabel)
PgEmployeeInfo.controls.add(me.CSSId)
PgEmployeeInfo.controls.add(me.CSSIdLabel)
PgEmployeeInfo.controls.add(me.CmdChangeHireDate)
TbEmployee.controls.add(me.PgPayroll)
PgPayroll.controls.add(me.ColaAdjusted)
PgPayroll.controls.add(me.ColaadjustedLabel)
PgPayroll.controls.add(me.RegularDaysHoursLabel)
PgPayroll.controls.add(me.CmdChangeSalaries)
PgPayroll.controls.add(me.CompanyPaidTaxesLabel)
PgPayroll.controls.add(me.IncreaseMonth)
PgPayroll.controls.add(me.IncreaseMonthLabel)
PgPayroll.controls.add(me.HourlySalaryCalcMethodID)
PgPayroll.controls.add(me.HourSalaryCalculationMethodLabel)
PgPayroll.controls.add(me.FixedHoursPerPeriod)
PgPayroll.controls.add(me.FixedHoursPerPeriodLabel)
PgPayroll.controls.add(me.DayLabel1)
PgPayroll.controls.add(me.Timein1)
PgPayroll.controls.add(me.Timeout1)
PgPayroll.controls.add(me.RegularHours1)
PgPayroll.controls.add(me.DayLabel2)
PgPayroll.controls.add(me.Timein2)
PgPayroll.controls.add(me.Timeout2)
PgPayroll.controls.add(me.RegularHours2)
PgPayroll.controls.add(me.DayLabel3)
PgPayroll.controls.add(me.Timein3)
PgPayroll.controls.add(me.Timeout3)
PgPayroll.controls.add(me.RegularHours3)
PgPayroll.controls.add(me.EmployeePaidTaxesLabel)
PgPayroll.controls.add(me.CmdDefaults)
PgPayroll.controls.add(me.DayLabel4)
PgPayroll.controls.add(me.Timein4)
PgPayroll.controls.add(me.Timeout4)
PgPayroll.controls.add(me.RegularHours4)
PgPayroll.controls.add(me.DayLabel5)
PgPayroll.controls.add(me.Timein5)
PgPayroll.controls.add(me.Timeout5)
PgPayroll.controls.add(me.RegularHours5)
PgPayroll.controls.add(me.DayLabel6)
PgPayroll.controls.add(me.Timein6)
PgPayroll.controls.add(me.Timeout6)
PgPayroll.controls.add(me.Box125)
PgPayroll.controls.add(me.RegularHours6)
PgPayroll.controls.add(me.DayLabel7)
PgPayroll.controls.add(me.Timein7)
PgPayroll.controls.add(me.Timeout7)
PgPayroll.controls.add(me.RegularHours7)
PgPayroll.controls.add(me.TxtTotHours)
PgPayroll.controls.add(me.EmployeeTypeID)
PgPayroll.controls.add(me.EmployeetypeLabel)
PgPayroll.controls.add(me.ChildEmployeeSalaryHistory)
PgPayroll.controls.add(me.CmdDeleteSalary)
TbEmployee.controls.add(me.PgOtherInfo)
PgOtherInfo.controls.add(me.ChkisSystemUser)
PgOtherInfo.controls.add(me.SystemUserLabel)
PgOtherInfo.controls.add(me.Username)
PgOtherInfo.controls.add(me.UsernameLabel)
PgOtherInfo.controls.add(me.DaysLabel)
PgOtherInfo.controls.add(me.ActiveLabelHelp)
PgOtherInfo.controls.add(me.Box163)
PgOtherInfo.controls.add(me.Password)
PgOtherInfo.controls.add(me.PasswordLabel)
PgOtherInfo.controls.add(me.SecurityLevelId)
PgOtherInfo.controls.add(me.RightsLabel)
PgOtherInfo.controls.add(me.PayslipLanguage)
PgOtherInfo.controls.add(me.PayslipLanguageLabel)
PgOtherInfo.controls.add(me.HolidaysPaidAfterDays)
PgOtherInfo.controls.add(me.ChkHolidaysPaid)
PgOtherInfo.controls.add(me.HolidaysPaidLabel)
PgOtherInfo.controls.add(me.ChkIsActive)
PgOtherInfo.controls.add(me.IsActiveLabel)
PgOtherInfo.controls.add(me.Unionid)
PgOtherInfo.controls.add(me.UnionLabel)
PgOtherInfo.controls.add(me.Notes)
PgOtherInfo.controls.add(me.NotesLabel)
PgOtherInfo.controls.add(me.DefaultServiceItemid)
PgOtherInfo.controls.add(me.DefaultServiceItemidLabel)
PgOtherInfo.controls.add(me.Defaultprojectid)
PgOtherInfo.controls.add(me.DefaultprojectidLabel)
PgOtherInfo.controls.add(me.DefaultCompany)
PgOtherInfo.controls.add(me.DefaultCompanyLabel)
TbEmployee.controls.add(me.Tab13th)
Tab13th.controls.add(me.ReleaseddateHelpLabel)
Tab13th.controls.add(me.AvailableVacationDays)
Tab13th.controls.add(me.AvailableSickDays)
Tab13th.controls.add(me.ReleasedDate)
Tab13th.controls.add(me.LastworkdateLabel)
Tab13th.controls.add(me.TerminationReasonId)
Tab13th.controls.add(me.TerminationReasonLabel)
Tab13th.controls.add(me.TermOptionPayExtraSalaries)
Tab13th.controls.add(me.ChkPayExtraSalariesLabel)
Tab13th.controls.add(me.TermOptionPaySickDaysOff)
Tab13th.controls.add(me.TermpaydaysoffsickLabel)
Tab13th.controls.add(me.Frame244)
Tab13th.controls.add(me.TerminationLabel)
Tab13th.controls.add(me.PaidPeriods)
Tab13th.controls.add(me.PaidPeriodsLabel)
Tab13th.controls.add(me.PermanentTerninaltionOnlyLabel)
Tab13th.controls.add(me.RegularPeriods)
Tab13th.controls.add(me.YearperiodsLabel)
Tab13th.controls.add(me.Lastpaydate)
Tab13th.controls.add(me.LastpaydateLabel)
Tab13th.controls.add(me.TxtUsedSickDays)
Tab13th.controls.add(me.AvailableLabel)
Tab13th.controls.add(me.TakenLabel)
Tab13th.controls.add(me.EarnedVacDaysleftLabel)
Tab13th.controls.add(me.TxtUsedVacationDays)
Tab13th.controls.add(me.TxtLeftSickDays)
Tab13th.controls.add(me.TxtLeftVacationDays)
Tab13th.controls.add(me.TxtTotalFinalExtraPay)
Tab13th.controls.add(me.TotalFinalExtraPayLabel)
Tab13th.controls.add(me.TxtEarnedSickDays)
Tab13th.controls.add(me.EarnedtodateLabel)
Tab13th.controls.add(me.TxtEarnedVacationDays)
Tab13th.controls.add(me.AvailableSickDaysLabel)
Tab13th.controls.add(me.AvailableVacationHoursLabel)
Tab13th.controls.add(me.Paidportion)
Tab13th.controls.add(me.PaidportionLabel)
Tab13th.controls.add(me.CmdNextYear)
Tab13th.controls.add(me.CmdPreviousYear)
Tab13th.controls.add(me.PayyearLabel)
Tab13th.controls.add(me.Filteryear)
Tab13th.controls.add(me.Frame335)
Tab13th.controls.add(me.VacationdaysStmtLabel)
Tab13th.controls.add(me.LeftLabel1)
Tab13th.controls.add(me.TxtLeftSickDaysPrev)
Tab13th.controls.add(me.TxtLeftVacationDaysPrev)
Tab13th.controls.add(me.TransferredDaysoff)
Tab13th.controls.add(me.TransferredDaysoffLabel)
Tab13th.controls.add(me.EmplLeaveTypeId)
Tab13th.controls.add(me.EmployeeAnnualLeaveTypeLabel)
TbEmployee.controls.add(me.PgAccounting)
PgAccounting.controls.add(me.EmplAccTypeId)
PgAccounting.controls.add(me.EmplAccTypeLabel)
PgAccounting.controls.add(me.PaymentAccountIDHelpLabel)
PgAccounting.controls.add(me.PaymentAccountID)
PgAccounting.controls.add(me.PaymentAccountIDLabel)
PgAccounting.controls.add(me.Frame309)
PgAccounting.controls.add(me.EmplOverheadLabel)
PgAccounting.controls.add(me.PayMethodID)
PgAccounting.controls.add(me.PaymethodLabel)
PgAccounting.controls.add(me.OhEmployeeCostHelpLabel)
PgAccounting.controls.add(me.OhHiringCostHelpLabel)
PgAccounting.controls.add(me.BankAccNumber)
PgAccounting.controls.add(me.BankAccNumberLabel)
PgAccounting.controls.add(me.BankAccountIBANCode)
PgAccounting.controls.add(me.BankAccountIBANCodeLabel)
PgAccounting.controls.add(me.BankId)
PgAccounting.controls.add(me.BankIdLabel)
PgAccounting.controls.add(me.EmplAccountBankSWIFTCode)
PgAccounting.controls.add(me.BankSWIFTCodeLabel)
PgAccounting.controls.add(me.BankBeneficiaryName)
PgAccounting.controls.add(me.BankBeneficiaryNameLabel)
PgAccounting.controls.add(me.BankBeneficiaryIdCode)
PgAccounting.controls.add(me.BankBeneficiaryIdCodeLabel)
PgAccounting.controls.add(me.NoPayForExtraHours)
PgAccounting.controls.add(me.NoPayForExtraHoursLabel)
PgAccounting.controls.add(me.BankBenNmHelp)
PgAccounting.controls.add(me.NoDeductionForLessHours)
PgAccounting.controls.add(me.NoDeductionForLessHoursLabel)
PgAccounting.controls.add(me.OhHiringCost)
PgAccounting.controls.add(me.EmplOhHiringCosts)
PgAccounting.controls.add(me.OhEmployeeCost)
PgAccounting.controls.add(me.EmplOhYearlyCosts)
TbEmployee.controls.add(me.HrinfoLabel)
HrinfoLabel.controls.add(me.Rankid)
HrinfoLabel.controls.add(me.RankLabel)
HrinfoLabel.controls.add(me.Departmentid)
HrinfoLabel.controls.add(me.DepartmentLabel)
HrinfoLabel.controls.add(me.ManagerEmplId)
HrinfoLabel.controls.add(me.ManagerEmplIdLabel)
HrinfoLabel.controls.add(me.ProbationEndDate)
HrinfoLabel.controls.add(me.ProbationEndDateLabel)
HrinfoLabel.controls.add(me.EmploymentStatusId)
HrinfoLabel.controls.add(me.EmploymentStatusLabel)
HrinfoLabel.controls.add(me.ForeignIdNumber)
HrinfoLabel.controls.add(me.ForeignIdNumberLabel)
HrinfoLabel.controls.add(me.Spoucename)
HrinfoLabel.controls.add(me.SpoucenameLabel)
HrinfoLabel.controls.add(me.WorkDescription)
HrinfoLabel.controls.add(me.WorkDescriptionLabel)
HrinfoLabel.controls.add(me.HbfileDescription1)
HrinfoLabel.controls.add(me.Label413)
HrinfoLabel.controls.add(me.HbfileDescription2)
HrinfoLabel.controls.add(me.Label415)
HrinfoLabel.controls.add(me.HbfileDescription3)
HrinfoLabel.controls.add(me.Label417)
Me.controls.add(me.Companyid)
Me.controls.add(me.EmployeeNo)
Me.controls.add(me.EmployeeNoLabel)
Me.controls.add(me.Createuser)
Me.controls.add(me.Updateuser)
Me.controls.add(me.CmdDelete)
Me.controls.add(me.CmdReviewReport)
Me.controls.add(me.CmdPrintSocIns)
Me.controls.add(me.CmdSave)
Me.controls.add(me.CmdClose)
Me.controls.add(me.CmdIncomeTax)
Me.controls.add(me.Employeeid)
Me.controls.add(me.Createdate)
Me.controls.add(me.CreatedateShortLabel)
Me.controls.add(me.Updatedate)
Me.controls.add(me.UpdatedShortLabel)
Me.controls.add(me.CmdNext)
Me.controls.add(me.CmdPrev)
Me.controls.add(me.CmdCopy)
        
        Me.Name = "FrmEmployee"
        Me.Text = " Σελίδα Uπαλλήλου"
		Me.ClientSize = New System.Drawing.Size(959, 508)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	
	End Sub

    Friend WithEvents TbEmployee As System.Windows.Forms.TabControl
Friend WithEvents PgEmployeeInfo As System.Windows.Forms.TabPage
Friend WithEvents Salutation As ConvertedMSAccessControls.AccessCombo
Friend WithEvents FirstName As Textbox
Friend WithEvents FirstNameLabel As Label
Friend WithEvents MiddleName As Textbox
Friend WithEvents MiddleNameLabel As Label
Friend WithEvents LastName As Textbox
Friend WithEvents LastNameLabel As Label
Friend WithEvents QuickBooksName As Textbox
Friend WithEvents QuickBooksNameLabel As Label
Friend WithEvents EmployeeAddressAddr1 As Textbox
Friend WithEvents Addr1Label As Label
Friend WithEvents EmployeeAddressAddr2 As Textbox
Friend WithEvents EmployeeAddressCity As Textbox
Friend WithEvents CityLabel As Label
Friend WithEvents EmployeeAddressState As Textbox
Friend WithEvents StateLabel As Label
Friend WithEvents EmployeeAddressPostalCode As Textbox
Friend WithEvents PostalCodeLabel As Label
Friend WithEvents EmployeeAddressCountry As Textbox
Friend WithEvents CountryLabel As Label
Friend WithEvents Telephone As Textbox
Friend WithEvents PhoneLabel As Label
Friend WithEvents MobilePhone As Textbox
Friend WithEvents MobilePhoneLabel As Label
Friend WithEvents Telephone2 As Textbox
Friend WithEvents Telephone2Label As Label
Friend WithEvents Email As Textbox
Friend WithEvents EmailLabel As Label
Friend WithEvents Genderid As ConvertedMSAccessControls.AccessCombo
Friend WithEvents GenderidLabel As Label
Friend WithEvents HiredDate As DateTimePicker
Friend WithEvents HiredDateLabel As Label
Friend WithEvents CmdCalHireddate As System.Windows.Forms.Button
Friend WithEvents SocialInsuranceNumber As Textbox
Friend WithEvents SocialInsuranceNumberLabel As Label
Friend WithEvents Cyprusidnumber As Textbox
Friend WithEvents CyprusidnumberLabel As Label
Friend WithEvents PayFrequencyID As ConvertedMSAccessControls.AccessCombo
Friend WithEvents PayFrequencyIDLabel As Label
Friend WithEvents Dateofbirth As Textbox
Friend WithEvents DateofbirthLabel As Label
Friend WithEvents CmdCalDateofbirth As System.Windows.Forms.Button
Friend WithEvents Placeofbirth As Textbox
Friend WithEvents PlaceofbirthLabel As Label
Friend WithEvents Maritalstatus As ConvertedMSAccessControls.AccessCombo
Friend WithEvents MaritalstatusLabel As Label
Friend WithEvents Professionid As ConvertedMSAccessControls.AccessCombo
Friend WithEvents ProfessionLabel As Label
Friend WithEvents AlienIDNumber As Textbox
Friend WithEvents AlienIDNumberLabel As Label
Friend WithEvents PassportNumber As Textbox
Friend WithEvents PassportNumberLabel As Label
Friend WithEvents SocinsCategoryid As ConvertedMSAccessControls.AccessCombo
Friend WithEvents SocinsCategoryLabel As Label
Friend WithEvents Ssicommunityid As ConvertedMSAccessControls.AccessCombo
Friend WithEvents SsicommunityidLabel As Label
Friend WithEvents DriverLicenceNo As Textbox
Friend WithEvents DriverLicenceNoLabel As Label
Friend WithEvents ITaxIdNumber As Textbox
Friend WithEvents ITaxIdNumberLabel As Label
Friend WithEvents CSSId As ConvertedMSAccessControls.AccessCombo
Friend WithEvents CSSIdLabel As Label
Friend WithEvents CmdChangeHireDate As System.Windows.Forms.Button
Friend WithEvents PgPayroll As System.Windows.Forms.TabPage
Friend WithEvents ColaAdjusted As System.Windows.Forms.Checkbox
Friend WithEvents ColaadjustedLabel As Label
Friend WithEvents RegularDaysHoursLabel As Label
Friend WithEvents CmdChangeSalaries As System.Windows.Forms.Button
Friend WithEvents CompanyPaidTaxesLabel As Label
Friend WithEvents IncreaseMonth As ConvertedMSAccessControls.AccessCombo
Friend WithEvents IncreaseMonthLabel As Label
Friend WithEvents HourlySalaryCalcMethodID As ConvertedMSAccessControls.AccessCombo
Friend WithEvents HourSalaryCalculationMethodLabel As Label
Friend WithEvents FixedHoursPerPeriod As Textbox
Friend WithEvents FixedHoursPerPeriodLabel As Label
Friend WithEvents DayLabel1 As Textbox
Friend WithEvents Timein1 As Textbox
Friend WithEvents Timeout1 As Textbox
Friend WithEvents RegularHours1 As Textbox
Friend WithEvents DayLabel2 As Textbox
Friend WithEvents Timein2 As Textbox
Friend WithEvents Timeout2 As Textbox
Friend WithEvents RegularHours2 As Textbox
Friend WithEvents DayLabel3 As Textbox
Friend WithEvents Timein3 As Textbox
Friend WithEvents Timeout3 As Textbox
Friend WithEvents RegularHours3 As Textbox
Friend WithEvents EmployeePaidTaxesLabel As Label
Friend WithEvents CmdDefaults As System.Windows.Forms.Button
Friend WithEvents DayLabel4 As Textbox
Friend WithEvents Timein4 As Textbox
Friend WithEvents Timeout4 As Textbox
Friend WithEvents RegularHours4 As Textbox
Friend WithEvents DayLabel5 As Textbox
Friend WithEvents Timein5 As Textbox
Friend WithEvents Timeout5 As Textbox
Friend WithEvents RegularHours5 As Textbox
Friend WithEvents DayLabel6 As Textbox
Friend WithEvents Timein6 As Textbox
Friend WithEvents Timeout6 As Textbox
Friend WithEvents Box125 As System.Windows.Forms.GroupBox
Friend WithEvents RegularHours6 As Textbox
Friend WithEvents DayLabel7 As Textbox
Friend WithEvents Timein7 As Textbox
Friend WithEvents Timeout7 As Textbox
Friend WithEvents RegularHours7 As Textbox
Friend WithEvents TxtTotHours As Textbox
Friend WithEvents EmployeeTypeID As ConvertedMSAccessControls.AccessCombo
Friend WithEvents EmployeetypeLabel As Label
Friend WithEvents ChildEmployeeSalaryHistory As ConvertedMSAccessControls.AccessListBox
Friend WithEvents CmdDeleteSalary As System.Windows.Forms.Button
Friend WithEvents PgOtherInfo As System.Windows.Forms.TabPage
Friend WithEvents ChkisSystemUser As System.Windows.Forms.Checkbox
Friend WithEvents SystemUserLabel As Label
Friend WithEvents Username As Textbox
Friend WithEvents UsernameLabel As Label
Friend WithEvents DaysLabel As Label
Friend WithEvents ActiveLabelHelp As Label
Friend WithEvents Box163 As System.Windows.Forms.GroupBox
Friend WithEvents Password As Textbox
Friend WithEvents PasswordLabel As Label
Friend WithEvents SecurityLevelId As ConvertedMSAccessControls.AccessCombo
Friend WithEvents RightsLabel As Label
Friend WithEvents PayslipLanguage As ConvertedMSAccessControls.AccessCombo
Friend WithEvents PayslipLanguageLabel As Label
Friend WithEvents HolidaysPaidAfterDays As Textbox
Friend WithEvents ChkHolidaysPaid As System.Windows.Forms.Checkbox
Friend WithEvents HolidaysPaidLabel As Label
Friend WithEvents ChkIsActive As System.Windows.Forms.Checkbox
Friend WithEvents IsActiveLabel As Label
Friend WithEvents Unionid As ConvertedMSAccessControls.AccessCombo
Friend WithEvents UnionLabel As Label
Friend WithEvents Notes As Textbox
Friend WithEvents NotesLabel As Label
Friend WithEvents DefaultServiceItemid As ConvertedMSAccessControls.AccessCombo
Friend WithEvents DefaultServiceItemidLabel As Label
Friend WithEvents Defaultprojectid As ConvertedMSAccessControls.AccessCombo
Friend WithEvents DefaultprojectidLabel As Label
Friend WithEvents DefaultCompany As ConvertedMSAccessControls.AccessCombo
Friend WithEvents DefaultCompanyLabel As Label
Friend WithEvents Tab13th As System.Windows.Forms.TabPage
Friend WithEvents ReleaseddateHelpLabel As Label
Friend WithEvents AvailableVacationDays As Textbox
Friend WithEvents AvailableSickDays As Textbox
Friend WithEvents ReleasedDate As DateTimePicker
Friend WithEvents LastworkdateLabel As Label
Friend WithEvents TerminationReasonId As ConvertedMSAccessControls.AccessCombo
Friend WithEvents TerminationReasonLabel As Label
Friend WithEvents TermOptionPayExtraSalaries As System.Windows.Forms.Checkbox
Friend WithEvents ChkPayExtraSalariesLabel As Label
Friend WithEvents TermOptionPaySickDaysOff As System.Windows.Forms.Checkbox
Friend WithEvents TermpaydaysoffsickLabel As Label
Friend WithEvents Frame244 As System.Windows.Forms.GroupBox
Friend WithEvents TerminationLabel As Label
Friend WithEvents PaidPeriods As Textbox
Friend WithEvents PaidPeriodsLabel As Label
Friend WithEvents PermanentTerninaltionOnlyLabel As Label
Friend WithEvents RegularPeriods As Textbox
Friend WithEvents YearperiodsLabel As Label
Friend WithEvents Lastpaydate As Textbox
Friend WithEvents LastpaydateLabel As Label
Friend WithEvents TxtUsedSickDays As Textbox
Friend WithEvents AvailableLabel As Label
Friend WithEvents TakenLabel As Label
Friend WithEvents EarnedVacDaysleftLabel As Label
Friend WithEvents TxtUsedVacationDays As Textbox
Friend WithEvents TxtLeftSickDays As Textbox
Friend WithEvents TxtLeftVacationDays As Textbox
Friend WithEvents TxtTotalFinalExtraPay As Textbox
Friend WithEvents TotalFinalExtraPayLabel As Label
Friend WithEvents TxtEarnedSickDays As Textbox
Friend WithEvents EarnedtodateLabel As Label
Friend WithEvents TxtEarnedVacationDays As Textbox
Friend WithEvents AvailableSickDaysLabel As Label
Friend WithEvents AvailableVacationHoursLabel As Label
Friend WithEvents Paidportion As Textbox
Friend WithEvents PaidportionLabel As Label
Friend WithEvents CmdNextYear As System.Windows.Forms.Button
Friend WithEvents CmdPreviousYear As System.Windows.Forms.Button
Friend WithEvents PayyearLabel As Label
Friend WithEvents Filteryear As Textbox
Friend WithEvents Frame335 As System.Windows.Forms.GroupBox
Friend WithEvents VacationdaysStmtLabel As Label
Friend WithEvents LeftLabel1 As Label
Friend WithEvents TxtLeftSickDaysPrev As Textbox
Friend WithEvents TxtLeftVacationDaysPrev As Textbox
Friend WithEvents TransferredDaysoff As Textbox
Friend WithEvents TransferredDaysoffLabel As Label
Friend WithEvents EmplLeaveTypeId As ConvertedMSAccessControls.AccessCombo
Friend WithEvents EmployeeAnnualLeaveTypeLabel As Label
Friend WithEvents PgAccounting As System.Windows.Forms.TabPage
Friend WithEvents EmplAccTypeId As ConvertedMSAccessControls.AccessCombo
Friend WithEvents EmplAccTypeLabel As Label
Friend WithEvents PaymentAccountIDHelpLabel As Label
Friend WithEvents PaymentAccountID As ConvertedMSAccessControls.AccessCombo
Friend WithEvents PaymentAccountIDLabel As Label
Friend WithEvents Frame309 As System.Windows.Forms.GroupBox
Friend WithEvents EmplOverheadLabel As Label
Friend WithEvents PayMethodID As ConvertedMSAccessControls.AccessCombo
Friend WithEvents PaymethodLabel As Label
Friend WithEvents OhEmployeeCostHelpLabel As Label
Friend WithEvents OhHiringCostHelpLabel As Label
Friend WithEvents BankAccNumber As Textbox
Friend WithEvents BankAccNumberLabel As Label
Friend WithEvents BankAccountIBANCode As Textbox
Friend WithEvents BankAccountIBANCodeLabel As Label
Friend WithEvents BankId As ConvertedMSAccessControls.AccessCombo
Friend WithEvents BankIdLabel As Label
Friend WithEvents EmplAccountBankSWIFTCode As Textbox
Friend WithEvents BankSWIFTCodeLabel As Label
Friend WithEvents BankBeneficiaryName As Textbox
Friend WithEvents BankBeneficiaryNameLabel As Label
Friend WithEvents BankBeneficiaryIdCode As Textbox
Friend WithEvents BankBeneficiaryIdCodeLabel As Label
Friend WithEvents NoPayForExtraHours As System.Windows.Forms.Checkbox
Friend WithEvents NoPayForExtraHoursLabel As Label
Friend WithEvents BankBenNmHelp As Label
Friend WithEvents NoDeductionForLessHours As System.Windows.Forms.Checkbox
Friend WithEvents NoDeductionForLessHoursLabel As Label
Friend WithEvents OhHiringCost As Textbox
Friend WithEvents EmplOhHiringCosts As Label
Friend WithEvents OhEmployeeCost As Textbox
Friend WithEvents EmplOhYearlyCosts As Label
Friend WithEvents HrinfoLabel As System.Windows.Forms.TabPage
Friend WithEvents Rankid As ConvertedMSAccessControls.AccessCombo
Friend WithEvents RankLabel As Label
Friend WithEvents Departmentid As ConvertedMSAccessControls.AccessCombo
Friend WithEvents DepartmentLabel As Label
Friend WithEvents ManagerEmplId As ConvertedMSAccessControls.AccessCombo
Friend WithEvents ManagerEmplIdLabel As Label
Friend WithEvents ProbationEndDate As DateTimePicker
Friend WithEvents ProbationEndDateLabel As Label
Friend WithEvents EmploymentStatusId As ConvertedMSAccessControls.AccessCombo
Friend WithEvents EmploymentStatusLabel As Label
Friend WithEvents ForeignIdNumber As Textbox
Friend WithEvents ForeignIdNumberLabel As Label
Friend WithEvents Spoucename As Textbox
Friend WithEvents SpoucenameLabel As Label
Friend WithEvents WorkDescription As Textbox
Friend WithEvents WorkDescriptionLabel As Label
Friend WithEvents HbfileDescription1 As Textbox
Friend WithEvents Label413 As Label
Friend WithEvents HbfileDescription2 As Textbox
Friend WithEvents Label415 As Label
Friend WithEvents HbfileDescription3 As Textbox
Friend WithEvents Label417 As Label
Friend WithEvents Companyid As Textbox
Friend WithEvents EmployeeNo As Textbox
Friend WithEvents EmployeeNoLabel As Label
Friend WithEvents Createuser As Textbox
Friend WithEvents Updateuser As Textbox
Friend WithEvents CmdDelete As System.Windows.Forms.Button
Friend WithEvents CmdReviewReport As System.Windows.Forms.Button
Friend WithEvents CmdPrintSocIns As System.Windows.Forms.Button
Friend WithEvents CmdSave As System.Windows.Forms.Button
Friend WithEvents CmdClose As System.Windows.Forms.Button
Friend WithEvents CmdIncomeTax As System.Windows.Forms.Button
Friend WithEvents Employeeid As Textbox
Friend WithEvents Createdate As Textbox
Friend WithEvents CreatedateShortLabel As Label
Friend WithEvents Updatedate As Textbox
Friend WithEvents UpdatedShortLabel As Label
Friend WithEvents CmdNext As System.Windows.Forms.Button
Friend WithEvents CmdPrev As System.Windows.Forms.Button
Friend WithEvents CmdCopy As System.Windows.Forms.Button

    Friend WithEvents ErrProvider As System.Windows.Forms.ErrorProvider
End Class
