'
' Form converted from MSAccess database using AccessDotNetConverter on Sunday, June 23, 2013
' https://code.google.com/p/msaccess-subversion-control
' 
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCompany
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
		
		 Me.__Name = New Textbox
Me.CompanyNameLabel = New Label
Me.Street = New Textbox
Me.StreetLabel = New Label
Me.Town = New Textbox
Me.TownLabel = New Label
Me.PostalCode = New Textbox
Me.PostalCodeLabel = New Label
Me.RegistrationNo = New Textbox
Me.RegistrationNoLabel = New Label
Me.Email = New Textbox
Me.EmailLabel = New Label
Me.Telephone = New Textbox
Me.TelephoneLabel = New Label
Me.Fax = New Textbox
Me.FaxLabel = New Label
Me.VatNo = New Textbox
Me.VatNoLabel = New Label
Me.Website = New Textbox
Me.WebsiteLabel = New Label
Me.SocialInsuranceNo = New Textbox
Me.SocialInsuranceNoLabel = New Label
Me.DepartmentsLabel = New Label
Me.Companyid = New Textbox
Me.CompanyidLabel = New Label
Me.IncomeTaxID = New Textbox
Me.IncomeTaxIDLabel = New Label
Me.CmdOK = New System.Windows.Forms.Button
Me.CmdCancel = New System.Windows.Forms.Button
Me.ITaxEmployeeId = New ConvertedMSAccessControls.AccessCombo
Me.ITaxEmployeeIdLabel = New Label
Me.ITaxNameProfession = New ConvertedMSAccessControls.AccessCombo
Me.ITaxNameProfessionLabel = New Label
Me.District = New Textbox
Me.DistrictLabel = New Label
Me.Ir7Activity = New Textbox
Me.Ir7ActivityLabel = New Label
Me.TaxationLabel = New Label
Me.Ir7EmployerType = New ConvertedMSAccessControls.AccessCombo
Me.Ir7EmployerTypeLabel = New Label
Me.ITaxName = New Textbox
Me.Label52 = New Label
Me.Ir7AuditorName = New Textbox
Me.Ir7AuditorNameLabel = New Label
Me.Ir7AuditorTelephone = New Textbox
Me.Ir7AuditorTelephoneLabel = New Label
Me.Ir7AuditorEmail = New Textbox
Me.Ir7AuditorEmailLabel = New Label
Me.Ir7AuditorTaxIdNo = New Textbox
Me.Ir7AuditorTaxIdNoLabel = New Label

        Me.SuspendLayout()
		
		Me.ErrProvider = New System.Windows.Forms.ErrorProvider()
 
	   'do tab pages here
        
Me.__Name.Name = "__Name"
Me.__Name.Location = New System.Drawing.Point(120, 28)
Me.__Name.Size = New System.Drawing.Size(434, 17)
Me.__Name.Visible=True
me.__Name.TabIndex = 1
me.__Name.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.__Name.TextAlign=HorizontalAlignment.Left


Me.CompanyNameLabel.Name = "CompanyNameLabel"
Me.CompanyNameLabel.Location = New System.Drawing.Point(0, 28)
Me.CompanyNameLabel.Size = New System.Drawing.Size(115, 17)
Me.CompanyNameLabel.Visible=True
me.CompanyNameLabel.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.CompanyNameLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.CompanyNameLabel.Text = "Όνομα Εταιρίας"

Me.CompanyNameLabel.forecolor = System.Drawing.ColorTranslator.FromOle(13209)

Me.Street.Name = "Street"
Me.Street.Location = New System.Drawing.Point(120, 49)
Me.Street.Size = New System.Drawing.Size(434, 17)
Me.Street.Visible=True
me.Street.TabIndex = 2
me.Street.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.Street.TextAlign=HorizontalAlignment.Left


Me.StreetLabel.Name = "StreetLabel"
Me.StreetLabel.Location = New System.Drawing.Point(0, 49)
Me.StreetLabel.Size = New System.Drawing.Size(115, 17)
Me.StreetLabel.Visible=True
me.StreetLabel.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.StreetLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.StreetLabel.Text = "Διεύθυνση"


Me.Town.Name = "Town"
Me.Town.Location = New System.Drawing.Point(120, 70)
Me.Town.Size = New System.Drawing.Size(164, 17)
Me.Town.Visible=True
me.Town.TabIndex = 3
me.Town.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.Town.TextAlign=HorizontalAlignment.Left


Me.TownLabel.Name = "TownLabel"
Me.TownLabel.Location = New System.Drawing.Point(0, 70)
Me.TownLabel.Size = New System.Drawing.Size(115, 17)
Me.TownLabel.Visible=True
me.TownLabel.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.TownLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.TownLabel.Text = "Πόλη"


Me.PostalCode.Name = "PostalCode"
Me.PostalCode.Location = New System.Drawing.Point(120, 91)
Me.PostalCode.Size = New System.Drawing.Size(164, 17)
Me.PostalCode.Visible=True
me.PostalCode.TabIndex = 5
me.PostalCode.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.PostalCode.TextAlign=HorizontalAlignment.Left


Me.PostalCodeLabel.Name = "PostalCodeLabel"
Me.PostalCodeLabel.Location = New System.Drawing.Point(0, 91)
Me.PostalCodeLabel.Size = New System.Drawing.Size(115, 16)
Me.PostalCodeLabel.Visible=True
me.PostalCodeLabel.Font = New System.Drawing.Font("Tahoma", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.PostalCodeLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.PostalCodeLabel.Text = "Ταχ. Τομέας"


Me.RegistrationNo.Name = "RegistrationNo"
Me.RegistrationNo.Location = New System.Drawing.Point(453, 175)
Me.RegistrationNo.Size = New System.Drawing.Size(113, 17)
Me.RegistrationNo.Visible=True
me.RegistrationNo.TabIndex = 11
me.RegistrationNo.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.RegistrationNo.TextAlign=HorizontalAlignment.Left


Me.RegistrationNoLabel.Name = "RegistrationNoLabel"
Me.RegistrationNoLabel.Location = New System.Drawing.Point(320, 175)
Me.RegistrationNoLabel.Size = New System.Drawing.Size(129, 17)
Me.RegistrationNoLabel.Visible=True
me.RegistrationNoLabel.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.RegistrationNoLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.RegistrationNoLabel.Text = "Αρ. Εγγραφής"


Me.Email.Name = "Email"
Me.Email.Location = New System.Drawing.Point(384, 112)
Me.Email.Size = New System.Drawing.Size(171, 17)
Me.Email.Visible=True
me.Email.TabIndex = 8
me.Email.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.Email.TextAlign=HorizontalAlignment.Left


Me.EmailLabel.Name = "EmailLabel"
Me.EmailLabel.Location = New System.Drawing.Point(290, 112)
Me.EmailLabel.Size = New System.Drawing.Size(84, 17)
Me.EmailLabel.Visible=True
me.EmailLabel.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.EmailLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.EmailLabel.Text = "Email"


Me.Telephone.Name = "Telephone"
Me.Telephone.Location = New System.Drawing.Point(120, 112)
Me.Telephone.Size = New System.Drawing.Size(164, 17)
Me.Telephone.Visible=True
me.Telephone.TabIndex = 7
me.Telephone.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.Telephone.TextAlign=HorizontalAlignment.Left


Me.TelephoneLabel.Name = "TelephoneLabel"
Me.TelephoneLabel.Location = New System.Drawing.Point(0, 112)
Me.TelephoneLabel.Size = New System.Drawing.Size(115, 17)
Me.TelephoneLabel.Visible=True
me.TelephoneLabel.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.TelephoneLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.TelephoneLabel.Text = "Τηλέφωνο"


Me.Fax.Name = "Fax"
Me.Fax.Location = New System.Drawing.Point(384, 91)
Me.Fax.Size = New System.Drawing.Size(171, 17)
Me.Fax.Visible=True
me.Fax.TabIndex = 6
me.Fax.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.Fax.TextAlign=HorizontalAlignment.Left


Me.FaxLabel.Name = "FaxLabel"
Me.FaxLabel.Location = New System.Drawing.Point(290, 91)
Me.FaxLabel.Size = New System.Drawing.Size(84, 17)
Me.FaxLabel.Visible=True
me.FaxLabel.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.FaxLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.FaxLabel.Text = "Φαξ"


Me.VatNo.Name = "VatNo"
Me.VatNo.Location = New System.Drawing.Point(452, 196)
Me.VatNo.Size = New System.Drawing.Size(113, 16)
Me.VatNo.Visible=True
me.VatNo.TabIndex = 13
me.VatNo.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.VatNo.TextAlign=HorizontalAlignment.Left


Me.VatNoLabel.Name = "VatNoLabel"
Me.VatNoLabel.Location = New System.Drawing.Point(296, 196)
Me.VatNoLabel.Size = New System.Drawing.Size(153, 16)
Me.VatNoLabel.Visible=True
me.VatNoLabel.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.VatNoLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.VatNoLabel.Text = "Αρ. Εγγραφής ΦΠΑ"


Me.Website.Name = "Website"
Me.Website.Location = New System.Drawing.Point(120, 132)
Me.Website.Size = New System.Drawing.Size(164, 16)
Me.Website.Visible=True
me.Website.TabIndex = 9
me.Website.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.Website.TextAlign=HorizontalAlignment.Left


Me.WebsiteLabel.Name = "WebsiteLabel"
Me.WebsiteLabel.Location = New System.Drawing.Point(0, 132)
Me.WebsiteLabel.Size = New System.Drawing.Size(115, 16)
Me.WebsiteLabel.Visible=True
me.WebsiteLabel.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.WebsiteLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.WebsiteLabel.Text = "Ιστοσελίδα"


Me.SocialInsuranceNo.Name = "SocialInsuranceNo"
Me.SocialInsuranceNo.Location = New System.Drawing.Point(161, 175)
Me.SocialInsuranceNo.Size = New System.Drawing.Size(113, 16)
Me.SocialInsuranceNo.Visible=True
me.SocialInsuranceNo.TabIndex = 10
me.SocialInsuranceNo.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.SocialInsuranceNo.TextAlign=HorizontalAlignment.Left


Me.SocialInsuranceNoLabel.Name = "SocialInsuranceNoLabel"
Me.SocialInsuranceNoLabel.Location = New System.Drawing.Point(5, 175)
Me.SocialInsuranceNoLabel.Size = New System.Drawing.Size(153, 16)
Me.SocialInsuranceNoLabel.Visible=True
me.SocialInsuranceNoLabel.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.SocialInsuranceNoLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.SocialInsuranceNoLabel.Text = "Αρ. Μητρώου Κοιν. Ασφ."

Me.SocialInsuranceNoLabel.forecolor = System.Drawing.ColorTranslator.FromOle(13209)

Me.DepartmentsLabel.Name = "DepartmentsLabel"
Me.DepartmentsLabel.Location = New System.Drawing.Point(12, 328)
Me.DepartmentsLabel.Size = New System.Drawing.Size(115, 16)
Me.DepartmentsLabel.Visible=True
me.DepartmentsLabel.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.DepartmentsLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.DepartmentsLabel.Text = "Τμήματα Εταιρίας"

Me.DepartmentsLabel.forecolor = System.Drawing.ColorTranslator.FromOle(-2147483630)

Me.Companyid.Name = "Companyid"
Me.Companyid.Location = New System.Drawing.Point(120, 6)
Me.Companyid.Size = New System.Drawing.Size(116, 16)
Me.Companyid.Visible=True
me.Companyid.TabIndex = 0
me.Companyid.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Companyid.backcolor =me.backcolor
me.Companyid.ReadOnly = True
me.Companyid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.Companyid.TextAlign=HorizontalAlignment.Left


Me.CompanyidLabel.Name = "CompanyidLabel"
Me.CompanyidLabel.Location = New System.Drawing.Point(0, 6)
Me.CompanyidLabel.Size = New System.Drawing.Size(115, 16)
Me.CompanyidLabel.Visible=True
me.CompanyidLabel.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.CompanyidLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.CompanyidLabel.Text = "Αρ. Εταιρίας"

Me.CompanyidLabel.forecolor = System.Drawing.ColorTranslator.FromOle(13209)

Me.IncomeTaxID.Name = "IncomeTaxID"
Me.IncomeTaxID.Location = New System.Drawing.Point(161, 196)
Me.IncomeTaxID.Size = New System.Drawing.Size(113, 16)
Me.IncomeTaxID.Visible=True
me.IncomeTaxID.TabIndex = 12
me.IncomeTaxID.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.IncomeTaxID.TextAlign=HorizontalAlignment.Left


Me.IncomeTaxIDLabel.Name = "IncomeTaxIDLabel"
Me.IncomeTaxIDLabel.Location = New System.Drawing.Point(5, 196)
Me.IncomeTaxIDLabel.Size = New System.Drawing.Size(153, 16)
Me.IncomeTaxIDLabel.Visible=True
me.IncomeTaxIDLabel.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.IncomeTaxIDLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.IncomeTaxIDLabel.Text = "Αρ. Φορολογικής Ταυτότητας"


Me.CmdOK.Name = "CmdOK"
Me.CmdOK.Location = New System.Drawing.Point(482, 392)
Me.CmdOK.Size = New System.Drawing.Size(85, 24)
Me.CmdOK.Visible=True
me.CmdOK.TabIndex = 25
me.CmdOK.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.CmdOK.Text = "&ΟΚ"
Me.CmdCancel.Name = "CmdCancel"
Me.CmdCancel.Location = New System.Drawing.Point(393, 392)
Me.CmdCancel.Size = New System.Drawing.Size(85, 24)
Me.CmdCancel.Visible=True
me.CmdCancel.TabIndex = 24
me.CmdCancel.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.CmdCancel.Text = "Ακύρωση"
Me.ITaxEmployeeId.Name = "ITaxEmployeeId"
Me.ITaxEmployeeId.Location = New System.Drawing.Point(173, 281)
Me.ITaxEmployeeId.Size = New System.Drawing.Size(123, 16)
Me.ITaxEmployeeId.Visible=True
me.ITaxEmployeeId.TabIndex = 18
me.ITaxEmployeeId.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.ITaxEmployeeId.RowSourceType = "Table/Query"
me.ITaxEmployeeId.RowSource = "SELECT employeeid, ename FROM vemployee; "

Me.ITaxEmployeeIdLabel.Name = "ITaxEmployeeIdLabel"
Me.ITaxEmployeeIdLabel.Location = New System.Drawing.Point(1, 281)
Me.ITaxEmployeeIdLabel.Size = New System.Drawing.Size(167, 16)
Me.ITaxEmployeeIdLabel.Visible=True
me.ITaxEmployeeIdLabel.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.ITaxEmployeeIdLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.ITaxEmployeeIdLabel.Text = "Όνομα Υπογράφοντος IR 63/7"

Me.ITaxEmployeeIdLabel.forecolor = System.Drawing.ColorTranslator.FromOle(-2147483630)

Me.ITaxNameProfession.Name = "ITaxNameProfession"
Me.ITaxNameProfession.Location = New System.Drawing.Point(173, 302)
Me.ITaxNameProfession.Size = New System.Drawing.Size(123, 16)
Me.ITaxNameProfession.Visible=True
me.ITaxNameProfession.TabIndex = 20
me.ITaxNameProfession.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.ITaxNameProfession.RowSourceType = "Value List"
me.ITaxNameProfession.RowSource = ""

Me.ITaxNameProfessionLabel.Name = "ITaxNameProfessionLabel"
Me.ITaxNameProfessionLabel.Location = New System.Drawing.Point(1, 302)
Me.ITaxNameProfessionLabel.Size = New System.Drawing.Size(167, 16)
Me.ITaxNameProfessionLabel.Visible=True
me.ITaxNameProfessionLabel.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.ITaxNameProfessionLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.ITaxNameProfessionLabel.Text = "Ιδιότητα Υπογράφοντος IR 63/7"

Me.ITaxNameProfessionLabel.forecolor = System.Drawing.ColorTranslator.FromOle(-2147483630)

Me.District.Name = "District"
Me.District.Location = New System.Drawing.Point(384, 70)
Me.District.Size = New System.Drawing.Size(171, 17)
Me.District.Visible=True
me.District.TabIndex = 4
me.District.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.District.TextAlign=HorizontalAlignment.Left


Me.DistrictLabel.Name = "DistrictLabel"
Me.DistrictLabel.Location = New System.Drawing.Point(290, 70)
Me.DistrictLabel.Size = New System.Drawing.Size(84, 16)
Me.DistrictLabel.Visible=True
me.DistrictLabel.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.DistrictLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.DistrictLabel.Text = "Επαρχία"

Me.DistrictLabel.forecolor = System.Drawing.ColorTranslator.FromOle(-2147483630)

Me.Ir7Activity.Name = "Ir7Activity"
Me.Ir7Activity.Location = New System.Drawing.Point(173, 239)
Me.Ir7Activity.Size = New System.Drawing.Size(123, 16)
Me.Ir7Activity.Visible=True
me.Ir7Activity.TabIndex = 14
me.Ir7Activity.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.Ir7Activity.TextAlign=HorizontalAlignment.Left


Me.Ir7ActivityLabel.Name = "Ir7ActivityLabel"
Me.Ir7ActivityLabel.Location = New System.Drawing.Point(1, 239)
Me.Ir7ActivityLabel.Size = New System.Drawing.Size(167, 16)
Me.Ir7ActivityLabel.Visible=True
me.Ir7ActivityLabel.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.Ir7ActivityLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.Ir7ActivityLabel.Text = "Δραστηριότητα "

Me.Ir7ActivityLabel.forecolor = System.Drawing.ColorTranslator.FromOle(-2147483630)

Me.TaxationLabel.Name = "TaxationLabel"
Me.TaxationLabel.Location = New System.Drawing.Point(4, 158)
Me.TaxationLabel.Size = New System.Drawing.Size(232, 17)
Me.TaxationLabel.Visible=True
me.TaxationLabel.Font = New System.Drawing.Font("MS Sans Serif", 10!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.TaxationLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft
Me.TaxationLabel.Text = "ΦΟΡΟΛΟΓΙΑ"

Me.TaxationLabel.forecolor = System.Drawing.ColorTranslator.FromOle(8388608)

Me.Ir7EmployerType.Name = "Ir7EmployerType"
Me.Ir7EmployerType.Location = New System.Drawing.Point(173, 260)
Me.Ir7EmployerType.Size = New System.Drawing.Size(123, 16)
Me.Ir7EmployerType.Visible=True
me.Ir7EmployerType.TabIndex = 16
me.Ir7EmployerType.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
me.Ir7EmployerType.RowSourceType = "Value List"
me.Ir7EmployerType.RowSource = "1;ΚΥΠΡΙΟΣ ΕΡΓΟΔΟΤΗΣ;2;ΑΛΛΟΔΑΠΗ ΕΤΑΙΡΙΑ ΜΕ ΔΡΑΣΤΗΡΙΟΤΗΤΕΣ ΣΤΟ ΕΞΩΤΕΡΙΚΟ;3;ΥΠΕΡΑΚΤΙΑ ΕΤΑΙΡΙΑ"

Me.Ir7EmployerTypeLabel.Name = "Ir7EmployerTypeLabel"
Me.Ir7EmployerTypeLabel.Location = New System.Drawing.Point(1, 260)
Me.Ir7EmployerTypeLabel.Size = New System.Drawing.Size(167, 16)
Me.Ir7EmployerTypeLabel.Visible=True
me.Ir7EmployerTypeLabel.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.Ir7EmployerTypeLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.Ir7EmployerTypeLabel.Text = "ΕΙΔΟΣ Εργοδότη (IR7)"

Me.Ir7EmployerTypeLabel.forecolor = System.Drawing.ColorTranslator.FromOle(-2147483630)

Me.ITaxName.Name = "ITaxName"
Me.ITaxName.Location = New System.Drawing.Point(383, 360)
Me.ITaxName.Size = New System.Drawing.Size(113, 16)
Me.ITaxName.Visible=False
me.ITaxName.TabIndex = 23
me.ITaxName.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.ITaxName.TextAlign=HorizontalAlignment.Left


Me.Label52.Name = "Label52"
Me.Label52.Location = New System.Drawing.Point(4, 218)
Me.Label52.Size = New System.Drawing.Size(232, 17)
Me.Label52.Visible=True
me.Label52.Font = New System.Drawing.Font("MS Sans Serif", 10!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.Label52.TextAlign=System.Drawing.ContentAlignment.MiddleLeft
Me.Label52.Text = "Πληροφορίες για R 7 / IR 63"

Me.Label52.forecolor = System.Drawing.ColorTranslator.FromOle(8388608)

Me.Ir7AuditorName.Name = "Ir7AuditorName"
Me.Ir7AuditorName.Location = New System.Drawing.Point(456, 240)
Me.Ir7AuditorName.Size = New System.Drawing.Size(113, 16)
Me.Ir7AuditorName.Visible=True
me.Ir7AuditorName.TabIndex = 15
me.Ir7AuditorName.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.Ir7AuditorName.TextAlign=HorizontalAlignment.Left


Me.Ir7AuditorNameLabel.Name = "Ir7AuditorNameLabel"
Me.Ir7AuditorNameLabel.Location = New System.Drawing.Point(300, 240)
Me.Ir7AuditorNameLabel.Size = New System.Drawing.Size(153, 16)
Me.Ir7AuditorNameLabel.Visible=True
me.Ir7AuditorNameLabel.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.Ir7AuditorNameLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.Ir7AuditorNameLabel.Text = "Ελεγκτής/Ελεγκτικός Οίκος"

Me.Ir7AuditorNameLabel.forecolor = System.Drawing.ColorTranslator.FromOle(-2147483630)

Me.Ir7AuditorTelephone.Name = "Ir7AuditorTelephone"
Me.Ir7AuditorTelephone.Location = New System.Drawing.Point(456, 261)
Me.Ir7AuditorTelephone.Size = New System.Drawing.Size(113, 16)
Me.Ir7AuditorTelephone.Visible=True
me.Ir7AuditorTelephone.TabIndex = 17
me.Ir7AuditorTelephone.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.Ir7AuditorTelephone.TextAlign=HorizontalAlignment.Left


Me.Ir7AuditorTelephoneLabel.Name = "Ir7AuditorTelephoneLabel"
Me.Ir7AuditorTelephoneLabel.Location = New System.Drawing.Point(300, 261)
Me.Ir7AuditorTelephoneLabel.Size = New System.Drawing.Size(153, 16)
Me.Ir7AuditorTelephoneLabel.Visible=True
me.Ir7AuditorTelephoneLabel.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.Ir7AuditorTelephoneLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.Ir7AuditorTelephoneLabel.Text = "Τηλέφωνο Ελεγκτή"

Me.Ir7AuditorTelephoneLabel.forecolor = System.Drawing.ColorTranslator.FromOle(-2147483630)

Me.Ir7AuditorEmail.Name = "Ir7AuditorEmail"
Me.Ir7AuditorEmail.Location = New System.Drawing.Point(456, 282)
Me.Ir7AuditorEmail.Size = New System.Drawing.Size(113, 16)
Me.Ir7AuditorEmail.Visible=True
me.Ir7AuditorEmail.TabIndex = 19
me.Ir7AuditorEmail.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.Ir7AuditorEmail.TextAlign=HorizontalAlignment.Left


Me.Ir7AuditorEmailLabel.Name = "Ir7AuditorEmailLabel"
Me.Ir7AuditorEmailLabel.Location = New System.Drawing.Point(300, 282)
Me.Ir7AuditorEmailLabel.Size = New System.Drawing.Size(153, 16)
Me.Ir7AuditorEmailLabel.Visible=True
me.Ir7AuditorEmailLabel.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.Ir7AuditorEmailLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.Ir7AuditorEmailLabel.Text = "Ηλεκτρ. Διεύθυνση Ελεγκτή"

Me.Ir7AuditorEmailLabel.forecolor = System.Drawing.ColorTranslator.FromOle(-2147483630)

Me.Ir7AuditorTaxIdNo.Name = "Ir7AuditorTaxIdNo"
Me.Ir7AuditorTaxIdNo.Location = New System.Drawing.Point(456, 303)
Me.Ir7AuditorTaxIdNo.Size = New System.Drawing.Size(113, 16)
Me.Ir7AuditorTaxIdNo.Visible=True
me.Ir7AuditorTaxIdNo.TabIndex = 21
me.Ir7AuditorTaxIdNo.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.Ir7AuditorTaxIdNo.TextAlign=HorizontalAlignment.Left


Me.Ir7AuditorTaxIdNoLabel.Name = "Ir7AuditorTaxIdNoLabel"
Me.Ir7AuditorTaxIdNoLabel.Location = New System.Drawing.Point(300, 303)
Me.Ir7AuditorTaxIdNoLabel.Size = New System.Drawing.Size(153, 16)
Me.Ir7AuditorTaxIdNoLabel.Visible=True
me.Ir7AuditorTaxIdNoLabel.Font = New System.Drawing.Font("MS Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.Ir7AuditorTaxIdNoLabel.TextAlign=System.Drawing.ContentAlignment.MiddleRight
Me.Ir7AuditorTaxIdNoLabel.Text = "ΑΦΤ Ελεγκτή"

Me.Ir7AuditorTaxIdNoLabel.forecolor = System.Drawing.ColorTranslator.FromOle(-2147483630)

       
		
		Me.ErrProvider.ContainerControl = Me
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        
        
Me.controls.add(me.__Name)
Me.controls.add(me.CompanyNameLabel)
Me.controls.add(me.Street)
Me.controls.add(me.StreetLabel)
Me.controls.add(me.Town)
Me.controls.add(me.TownLabel)
Me.controls.add(me.PostalCode)
Me.controls.add(me.PostalCodeLabel)
Me.controls.add(me.RegistrationNo)
Me.controls.add(me.RegistrationNoLabel)
Me.controls.add(me.Email)
Me.controls.add(me.EmailLabel)
Me.controls.add(me.Telephone)
Me.controls.add(me.TelephoneLabel)
Me.controls.add(me.Fax)
Me.controls.add(me.FaxLabel)
Me.controls.add(me.VatNo)
Me.controls.add(me.VatNoLabel)
Me.controls.add(me.Website)
Me.controls.add(me.WebsiteLabel)
Me.controls.add(me.SocialInsuranceNo)
Me.controls.add(me.SocialInsuranceNoLabel)
Me.controls.add(me.DepartmentsLabel)
Me.controls.add(me.Companyid)
Me.controls.add(me.CompanyidLabel)
Me.controls.add(me.IncomeTaxID)
Me.controls.add(me.IncomeTaxIDLabel)
Me.controls.add(me.CmdOK)
Me.controls.add(me.CmdCancel)
Me.controls.add(me.ITaxEmployeeId)
Me.controls.add(me.ITaxEmployeeIdLabel)
Me.controls.add(me.ITaxNameProfession)
Me.controls.add(me.ITaxNameProfessionLabel)
Me.controls.add(me.District)
Me.controls.add(me.DistrictLabel)
Me.controls.add(me.Ir7Activity)
Me.controls.add(me.Ir7ActivityLabel)
Me.controls.add(me.TaxationLabel)
Me.controls.add(me.Ir7EmployerType)
Me.controls.add(me.Ir7EmployerTypeLabel)
Me.controls.add(me.ITaxName)
Me.controls.add(me.Label52)
Me.controls.add(me.Ir7AuditorName)
Me.controls.add(me.Ir7AuditorNameLabel)
Me.controls.add(me.Ir7AuditorTelephone)
Me.controls.add(me.Ir7AuditorTelephoneLabel)
Me.controls.add(me.Ir7AuditorEmail)
Me.controls.add(me.Ir7AuditorEmailLabel)
Me.controls.add(me.Ir7AuditorTaxIdNo)
Me.controls.add(me.Ir7AuditorTaxIdNoLabel)
        
        Me.Name = "FrmCompany"
        Me.Text = " Στοιχεία Εταιρίας"
		Me.ClientSize = New System.Drawing.Size(583, 451)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	
	End Sub

    Friend WithEvents __Name As Textbox
Friend WithEvents CompanyNameLabel As Label
Friend WithEvents Street As Textbox
Friend WithEvents StreetLabel As Label
Friend WithEvents Town As Textbox
Friend WithEvents TownLabel As Label
Friend WithEvents PostalCode As Textbox
Friend WithEvents PostalCodeLabel As Label
Friend WithEvents RegistrationNo As Textbox
Friend WithEvents RegistrationNoLabel As Label
Friend WithEvents Email As Textbox
Friend WithEvents EmailLabel As Label
Friend WithEvents Telephone As Textbox
Friend WithEvents TelephoneLabel As Label
Friend WithEvents Fax As Textbox
Friend WithEvents FaxLabel As Label
Friend WithEvents VatNo As Textbox
Friend WithEvents VatNoLabel As Label
Friend WithEvents Website As Textbox
Friend WithEvents WebsiteLabel As Label
Friend WithEvents SocialInsuranceNo As Textbox
Friend WithEvents SocialInsuranceNoLabel As Label
Friend WithEvents DepartmentsLabel As Label
Friend WithEvents Companyid As Textbox
Friend WithEvents CompanyidLabel As Label
Friend WithEvents IncomeTaxID As Textbox
Friend WithEvents IncomeTaxIDLabel As Label
Friend WithEvents CmdOK As System.Windows.Forms.Button
Friend WithEvents CmdCancel As System.Windows.Forms.Button
Friend WithEvents ITaxEmployeeId As ConvertedMSAccessControls.AccessCombo
Friend WithEvents ITaxEmployeeIdLabel As Label
Friend WithEvents ITaxNameProfession As ConvertedMSAccessControls.AccessCombo
Friend WithEvents ITaxNameProfessionLabel As Label
Friend WithEvents District As Textbox
Friend WithEvents DistrictLabel As Label
Friend WithEvents Ir7Activity As Textbox
Friend WithEvents Ir7ActivityLabel As Label
Friend WithEvents TaxationLabel As Label
Friend WithEvents Ir7EmployerType As ConvertedMSAccessControls.AccessCombo
Friend WithEvents Ir7EmployerTypeLabel As Label
Friend WithEvents ITaxName As Textbox
Friend WithEvents Label52 As Label
Friend WithEvents Ir7AuditorName As Textbox
Friend WithEvents Ir7AuditorNameLabel As Label
Friend WithEvents Ir7AuditorTelephone As Textbox
Friend WithEvents Ir7AuditorTelephoneLabel As Label
Friend WithEvents Ir7AuditorEmail As Textbox
Friend WithEvents Ir7AuditorEmailLabel As Label
Friend WithEvents Ir7AuditorTaxIdNo As Textbox
Friend WithEvents Ir7AuditorTaxIdNoLabel As Label

    Friend WithEvents ErrProvider As System.Windows.Forms.ErrorProvider
End Class
