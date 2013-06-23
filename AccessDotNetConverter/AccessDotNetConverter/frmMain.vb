
Imports System.Threading
Imports System.Xml.Serialization
Imports System.IO

Imports System.Reflection

Public Class frmMain

    Private Const STR_REG_APPL As String = "AccessDotNetConverter"
    Private Const STR_REG_SECTION As String = "Settings"
    Private Const INT_MAX_REMEMBERED_FILES As Integer = 10

    ' Private ReadOnly FI_DEFAULT_CONFIG As FileInfo = New FileInfo(AccessConversionContext.DEFAULT_CONFIG_FILE)

    Private writer As TextBoxWriter = Nothing

    Private _needsSave As Boolean

    Private Sub InfoMessageReceived(ByVal msg As String)

        Me.txtResultsLog.Text = Me.txtResultsLog.Text & vbCrLf & msg

    End Sub

    Private Sub tsNewProject_click(sender As System.Object, e As System.EventArgs) Handles tsNewProject.Click

        sfdSaveConfig.Filter = "XML Project File|*.xml"
        sfdSaveConfig.Title = "Select Project File Name"
        sfdSaveConfig.DefaultExt = ".xml"

        sfdSaveConfig.AddExtension = True
        sfdSaveConfig.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        sfdSaveConfig.DefaultExt = ".xml"
        sfdSaveConfig.OverwritePrompt = True
        sfdSaveConfig.ShowDialog()

        If sfdSaveConfig.FileName = "" Then Exit Sub
       
        If File.Exists(sfdSaveConfig.FileName) Then
            File.Delete(sfdSaveConfig.FileName)
        End If

        Using tr As New StringReader(My.Resources.defaultProjectConfig)
            Dim x As XDocument
            x = XDocument.Load(tr)
            x.Document.Element("AccessToDotNetConfig").Attribute("targetDotNetProjectPath").Value = ""
            x.Document.Element("AccessToDotNetConfig").Attribute("sourceAccessDatabase").Value = ""
            x.Save(sfdSaveConfig.FileName)

        End Using

        Me.cboXMLConfFile.Items.Add(sfdSaveConfig.FileName)
        Me.cboXMLConfFile.Text = sfdSaveConfig.FileName

    End Sub

    Private Sub btnSelectDotNetFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectDotNetFolder.Click

        Me.fbSelectSVNFolder.Description = "Select .NET Project root Folder"
        Me.fbSelectSVNFolder.ShowNewFolderButton = True

        Dim lastUsed As String = GetSetting(STR_REG_APPL, STR_REG_SECTION, "lastSelectDotNetFolder", String.Empty)
        If String.IsNullOrEmpty(lastUsed) = False AndAlso Directory.Exists(lastUsed) Then
            Me.fbSelectSVNFolder.SelectedPath = lastUsed
        End If

        Me.fbSelectSVNFolder.ShowDialog()
        If Me.fbSelectSVNFolder.SelectedPath <> "" Then
            SaveSetting(STR_REG_APPL, STR_REG_SECTION, "lastSelectDotNetFolder", Me.fbSelectSVNFolder.SelectedPath)
            Me.txtDotNetProjectPath.Text = Me.fbSelectSVNFolder.SelectedPath
            AccessConversionContext.current.dotNetProjectPath = Me.txtDotNetProjectPath.Text

            _needsSave = True

        End If
    End Sub

    Private Sub btnSelectAccessDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectAccessDB.Click

        'ofSelectAccessDB.CheckFileExists = True
        ofSelectFile.CheckPathExists = True
        'Image Files (*.bmp, *.jpg)|*.bmp;*.jpg
        ofSelectFile.Filter = "Access Databases|*.accdb;*.mdb;*.adp|All Files|*.*"
        ofSelectFile.FileName = String.Empty
        ofSelectFile.Multiselect = False
        ofSelectFile.Title = "Select Microsoft Access Database File"
        ofSelectFile.ShowDialog()

        If ofSelectFile.FileName <> String.Empty Then
            Me.txtDatabase.Text = ofSelectFile.FileName
            AccessConversionContext.current.sourceAccessDatabase = Me.txtDatabase.Text
            Me.ucFormList.lstForms.DataSource = AccessConversionContext.current.getAllAccessForms
            _needsSave = True
        End If
    End Sub

    Private Sub RunConversion(ByVal sender As System.Object, ByVal e As System.EventArgs)

        For Each frm As String In Me.ucFormList.lstForms.SelectedItems

            AccessConversionContext.current.convertForm(frm)

        Next

    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.writer = New TextBoxWriter(Me.txtResultsLog)
        Console.SetOut(writer)

        For i As Integer = 0 To INT_MAX_REMEMBERED_FILES
            Dim regXmlConfFile As String = GetSetting(STR_REG_APPL, STR_REG_SECTION, "Path" & i, String.Empty)
            If regXmlConfFile <> String.Empty Then
                If System.IO.File.Exists(regXmlConfFile) Then
                    Me.cboXMLConfFile.Items.Add(regXmlConfFile)
                End If

            End If
        Next

        If Me.cboXMLConfFile.Items.Count > 0 Then
            Me.cboXMLConfFile.SelectedItem = Me.cboXMLConfFile.Items(0)

            ' Me.cboXMLConfFile.Items.Add(FI_DEFAULT_CONFIG.FullName)


        End If

        
        AddHandler Me.ucFormList.btnRunConversion.Click, AddressOf RunConversion
        AddHandler Me.ucFormList.btnRunConversion.Click, AddressOf RefreshFormList

    End Sub

    Private Sub tsmiOpenProject_Click(ByVal sender As System.Object, _
         ByVal e As System.EventArgs) Handles tsmiOpenProject.Click

        Me.openConfigurationFile()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmiExit.Click

        Application.Exit()

    End Sub

    Private Sub tsmiSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiSave.Click

        If validateProjectInfo() = False Then
            Exit Sub
        End If

        'if the config loaded is the default config, select another name
        Dim thisConfigFile As String = AccessConversionContext.current.configFile

        If String.IsNullOrEmpty(Me.cboXMLConfFile.Text) Then

            sfdSaveConfig.AddExtension = True
            ofSelectFile.Filter = "XML Project File|*.xml|All Files|*.*"
            sfdSaveConfig.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
            sfdSaveConfig.DefaultExt = ".xml"
            sfdSaveConfig.OverwritePrompt = True
            sfdSaveConfig.ShowDialog()


            If sfdSaveConfig.FileName = "" Then Exit Sub
            
            thisConfigFile = sfdSaveConfig.FileName
        End If

        Me.saveProjectInfo(thisConfigFile)

    End Sub

    Private Sub saveProjectInfo(newConfigFile As String)

        Dim cfile As FileInfo = New FileInfo(newConfigFile)
        AccessConversionContext.current.updateConfig(cfile, Me.txtDatabase.Text, Me.txtDotNetProjectPath.Text)
        If Me.cboXMLConfFile.Items.Contains(newConfigFile) = False Then
            Me.cboXMLConfFile.Items.Add(newConfigFile)

        End If
        Me.cboXMLConfFile.Text = newConfigFile

    End Sub

    Private Function validateProjectInfo() As Boolean

        If String.IsNullOrEmpty(Me.cboXMLConfFile.Text) Then
            MsgBox("Please give a ConfigFile.", MsgBoxStyle.Critical)
            Return False
        End If

        If IO.File.Exists(Me.txtDatabase.Text) = False Then
            MsgBox("Access Source Database Fle does not exist, or is empty", MsgBoxStyle.Critical)
            Return False
        End If
        If IO.Directory.Exists(Me.txtDotNetProjectPath.Text) = False Then
            MsgBox("Dot Net Project Path Folder not exist, or is empty.", MsgBoxStyle.Critical)
            Return False
        End If

        Return True

    End Function


    Private Function getMyVersion() As String
        Return Assembly.GetExecutingAssembly.GetName.Version.ToString
    End Function


    Private Sub btnOpenConfig_Click(sender As System.Object, e As System.EventArgs) _
            Handles btnOpenConfig.Click

        Call openConfigurationFile()

    End Sub

    Private Sub openConfigurationFile()

        ofSelectFile.CheckFileExists = True
        ofSelectFile.CheckPathExists = True

        ofSelectFile.Filter = "XML Project File|*.xml|All Files|*.*"
        ofSelectFile.FileName = String.Empty
        ofSelectFile.Multiselect = False
        ofSelectFile.Title = "Select Configuration File"
        ofSelectFile.ShowDialog()

        If ofSelectFile.FileName <> String.Empty Then
            If Me.cboXMLConfFile.Items.Contains(ofSelectFile.FileName) = False Then
                Me.cboXMLConfFile.Items.Add(ofSelectFile.FileName)

            End If
            Me.cboXMLConfFile.Text = ofSelectFile.FileName
        End If

    End Sub
    Private Sub loadConfigurationFile(configFile As String)
        Try
            Me.txtResultsLog.Text = String.Empty

            Console.WriteLine("Loading Configuration File {0}", configFile)
            SaveSetting(STR_REG_APPL, STR_REG_SECTION, "ConfigFile", configFile)
            AccessConversionContext.setCurrent(configFile)

            Me.Text = Me.getFormCaption()

            ' Console.WriteLine("Configuration File {0} Loaded.", configFile)

        Catch ex As Exception
            Console.WriteLine("Error Loading configuration file {0}:{1}", configFile, ex.Message)
            Console.WriteLine(ex.StackTrace)
            Exit Sub
        End Try

        Me.txtDatabase.Text = AccessConversionContext.current.sourceAccessDatabase
        If String.IsNullOrEmpty(AccessConversionContext.current.dotNetProjectPath) Then
            Me.txtDotNetProjectPath.Text = String.Empty

        Else
            Me.txtDotNetProjectPath.Text = New DirectoryInfo(AccessConversionContext.current.dotNetProjectPath).FullName

        End If

        If String.IsNullOrEmpty(Me.txtDatabase.Text) Then
            Me.ucFormList.lstForms.DataSource = Nothing
            'Me.ucFormList.lstForms.Items.Clear()
        Else
            Me.ucFormList.lstForms.DataSource = AccessConversionContext.current.getAllAccessForms
        End If



    End Sub


    Public Shared Sub Main()

        If checkCommandLine() = False Then
            Using f As New frmMain
                f.ShowDialog()
            End Using
        End If


    End Sub

    ''' <summary>
    ''' Checks the command line arguments and goes into command line mode if the proper arguments 
    ''' are supplied
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks>
    ''' Syntax of Command line:
    ''' 1. <code>AccessDotNetConverter -form [formname] -configFile [configfile]</code>
    ''' Loads the config file specified in "configFile" parameter, and converts form name specified in parameter - form
    ''' 2. <code>AccessDotNetConverter -form [formname] -sourceAccessDatabase [path to ms access database]</code>
    ''' Converts form name specified in parameter "form" from the access database specified in the "sourceAccessDatabase" parameter. 
    ''' The configuration file used is the default configuration file of the application
    ''' <code></code>
    ''' </remarks>
    Private Shared Function checkCommandLine() As Boolean

        Dim formname As String = String.Empty
        Dim configFile As String = String.Empty
        Dim accessdb As String = String.Empty

        Dim args As System.Collections.ObjectModel.ReadOnlyCollection(Of String) = My.Application.CommandLineArgs

        If args.Count > 0 Then

            For i As Integer = 0 To args.Count

                If args(i) = "-form" Then
                    formname = args(i + 1)
                End If
                If args(i) = "-sourceAccessDatabase" Then
                    accessdb = args(i + 1)
                End If
                If args(i) = "-configFile" Then
                    configFile = args(i + 1)
                End If

            Next
            If String.IsNullOrEmpty(configFile) Then
                configFile = GetSetting(STR_REG_APPL, STR_REG_SECTION, "ConfigFile", String.Empty)
                If String.IsNullOrEmpty(configFile) Then
                    'use the default config file.
                    configFile = AccessConversionContext.DEFAULT_CONFIG_FILE
                End If
            End If

            If String.IsNullOrEmpty(formname) Then
                Console.WriteLine("Error: no form name to convert given. Use -form [formname] parameter")
            End If

            AccessConversionContext.setCurrent(configFile)
            If (String.IsNullOrEmpty(accessdb) = False) Then
                AccessConversionContext.current.sourceAccessDatabase = accessdb
            End If

            AccessConversionContext.current.convertForm(formname)

            Return True

        End If

        Return False

    End Function

    Private Function getFormCaption() As String

        Return "Access To .Net Forms Converter " & getMyVersion() & " Project: " & AccessConversionContext.current.ProjectName

    End Function

    Private Sub txtConfigFile_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cboXMLConfFile.KeyPress

        ' Stop any character from being entered into the control
        e.Handled = True

    End Sub

    'this should be called from selectedItemChanged
    Private Sub setConfigFileDropDown()

        SaveSetting(STR_REG_APPL, STR_REG_SECTION, "Path0", Me.cboXMLConfFile.Text)
        For i As Integer = 1 To INT_MAX_REMEMBERED_FILES
            SaveSetting(STR_REG_APPL, STR_REG_SECTION, "Path" & i, String.Empty)
        Next

        For i As Integer = 0 To Me.cboXMLConfFile.Items.Count - 1
            Dim regXmlConfFile As String = CStr(Me.cboXMLConfFile.Items(i))
            If regXmlConfFile <> String.Empty Then
                If regXmlConfFile <> Me.cboXMLConfFile.Text Then
                    If System.IO.File.Exists(regXmlConfFile) Then
                        'Me.cboXMLConfFile.Items.Add(regXmlConfFile)
                        SaveSetting(STR_REG_APPL, STR_REG_SECTION, "Path" & (i + 1), regXmlConfFile)
                    End If
                End If
            End If
        Next



    End Sub

    Private Sub cboXMLConfFile_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) _
            Handles cboXMLConfFile.SelectedIndexChanged

        If Me.cboXMLConfFile.SelectedItem IsNot Nothing Then

            Call loadConfigurationFile(Me.cboXMLConfFile.SelectedItem)
            Call setConfigFileDropDown()

        End If

    End Sub


    Private Sub RefreshFormList(sender As Object, e As EventArgs)
        Me.ucFormList.lstForms.DataSource = AccessConversionContext.current.getAllAccessForms
    End Sub

End Class
