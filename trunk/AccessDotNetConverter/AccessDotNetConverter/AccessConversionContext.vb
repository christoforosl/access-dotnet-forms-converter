' SVN revision information:
' @version 
' @author  
' @date
'
Imports System.IO
Imports System.Runtime.InteropServices

''' <summary>
''' Singleton Class for the Context of the Conversion
''' </summary>
Public Class AccessConversionContext

    Public Const DEFAULT_CONFIG_FILE As String = "defaultProjectConfig.xml"

    ''' <summary>
    ''' The current access form being converted
    ''' </summary>
    ''' <remarks></remarks>
    Private _accessForm As Object 'Access.Form

    Private _ProjectName As String

    ''' <summary>
    ''' A reference to the configuration XML file
    ''' </summary>
    Public Property Config As XDocument

    ''' <summary>
    ''' Gets/Sets the class that implements interface INamingHandler, 
    ''' that handles conversion of MS Access object names to .NET object names
    ''' </summary>
    ''' <remarks>Config File option:namingHandler</remarks>
    Public Property ControlsNameHandler As INamingHandler

    ''' <summary>
    ''' Gets/Sets the name of the base Form of the converted MS Accss Forms
    ''' </summary>
    ''' <remarks>Normally, this would be <code>System.Windows.Forms.Form</code>
    ''' But you could have your own Base form and specify it in the configuration file.
    ''' </remarks>
    Public Property defaultBaseForm As String

    Private _accessApplication As Object 'Access.Application

    Private _dotNetProjectPath As String 'Access.Application

    ''' <summary>
    ''' Gets/Sets The root .Net project path to write the produced form files
    ''' </summary>
    Public Property dotNetProjectPath As String
        Get
            Return _dotNetProjectPath
        End Get
        Set(value As String)

            If Not String.IsNullOrEmpty(value) AndAlso value.EndsWith("\") = False Then
                value &= "\"
            End If

            _dotNetProjectPath = value
        End Set
    End Property
    ''' <summary>
    ''' The Source access dataabase (ADP or MDB) to convert form(s)
    ''' </summary>
    Public Property sourceAccessDatabase As String

    Private Shared instance As AccessConversionContext

    ''' <summary>
    ''' The file extension, .vb for Visual Basic, or .cs for C#
    ''' </summary>
    Private Property convertedFilesExtension As String

    Private _configFile As String

    ''' <summary>
    ''' MS Access automation returns the control collection of a Form both in a flat and a hierchical way
    ''' So if a control is a child of a tab page, it will appear twice will processing, one 
    ''' under the Form and once under the tab control.  This List keeps names of processed 
    ''' controls to avoid double processing
    ''' </summary>
    Public Property processedControls As List(Of String) = New List(Of String)

    ''' <summary>
    ''' Returns the Singleton object instance
    ''' </summary>
    Public Shared Function current() As AccessConversionContext

        If instance Is Nothing Then
            Throw New ApplicationException("Must call setCurrent(configFile As String) first")
        End If

        Return instance
    End Function


    ''' <summary>
    ''' Sets the Singleton object instance from a new config file.
    ''' </summary>
    Public Shared Sub setCurrent(configFile As String)

        If File.Exists(configFile) = False Then
            Throw New ApplicationException(String.Format("Error: configFile ""{0}"" does not exist.", configFile))
        End If

        instance = New AccessConversionContext(configFile)

    End Sub


    Public ReadOnly Property configFile() As String
        Get
            Return _configFile
        End Get

    End Property

    ''' <summary>
    ''' Creates a new context from the specified config file
    ''' </summary>
    Private Sub New(inConfigFile As String)

        _configFile = inConfigFile

        Me._ProjectName = New FileInfo(Me.configFile).Name
        Me.Config = XDocument.Load(Me.configFile)

        Dim elmnt As XElement = Me.Config.Element("AccessToDotNetConfig")
        Me.dotNetProjectPath = elmnt.Attribute("targetDotNetProjectPath").Value()

        If String.IsNullOrEmpty(Me.dotNetProjectPath) = False Then
            If Directory.Exists(Me.dotNetProjectPath) = False Then
                Console.WriteLine(String.Format("Error: dotNetProjectPath ""{0}"" does not exist.", Me.dotNetProjectPath))
            End If
        End If

        Me.sourceAccessDatabase = elmnt.Attribute("sourceAccessDatabase").Value()

        If String.IsNullOrEmpty(Me.sourceAccessDatabase) = False Then
            If File.Exists(Me.sourceAccessDatabase) = False Then
                Console.WriteLine(String.Format("Error: sourceAccessDatabase ""{0}"" does not exist.", Me.sourceAccessDatabase))
            End If
        End If


        Me.convertedFilesExtension = elmnt.Attribute("fileExtension").Value()
        Me.defaultBaseForm = elmnt.Attribute("defaultBaseForm").Value()

        Dim namingHandlerClass As String = elmnt.Attribute("namingHandler").Value()
        If String.IsNullOrEmpty(namingHandlerClass) Then
            Me.ControlsNameHandler = New DefaultNameHandler
        Else
            Me.ControlsNameHandler = Activator.CreateInstance(Type.GetType(namingHandlerClass))
        End If


    End Sub
    ''' <summary>
    ''' Gets the  MS Access COM automation object
    ''' </summary>
    Public ReadOnly Property AccessApplication() As Object 'Access.Application
        Get
            If _accessApplication Is Nothing Then
                Me.openAccessDatabase()
            End If
            Return _accessApplication
        End Get
    End Property

    Private Shared Function getOrCreateAccessComReference() As Object

        Dim accessAppObj As Object = Nothing
        Dim accessClassId As String = "Access.Application"

        Try
            accessAppObj = Marshal.GetActiveObject(accessClassId)
            ' Console.WriteLine("Got access application reference:" & accessAppObj.GetHashCode)
        Catch e As Exception
            accessAppObj = Nothing
        End Try

        If accessAppObj Is Nothing Then
            accessAppObj = CreateObject(accessClassId)
            'Console.WriteLine("Sucessfully created application reference:" & accessAppObj.GetHashCode)
        End If

        Return accessAppObj

    End Function

    ''' <summary>
    ''' Create an MS Access COM automation object, and open the MS Acces database.
    ''' The instantiation of the MS Access COM automation object happens 
    ''' by calling <code>Marshal.GetActiveObject("Access.Application")</code> first
    ''' and then  <code>CreateObject("Access.Application")</code>
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub openAccessDatabase()

        Dim fiAccess As FileInfo = New FileInfo(Me.sourceAccessDatabase)
        If fiAccess.Exists = False Then
            Throw New ApplicationException(String.Format("Access File {0} does not exist", fiAccess.FullName))
        End If
        Try

            _accessApplication = getOrCreateAccessComReference()
            _accessApplication.Visible = False
            _accessApplication.UserControl = False

            Try
                _accessApplication.CloseCurrentDatabase()
            Catch exception As Exception
                'just ignore error!
            End Try


            If Me.sourceAccessDatabase.ToLower.EndsWith("adp") Then
                _accessApplication.OpenAccessProject(Me.sourceAccessDatabase, False)
            Else
                Dim fdb As FileInfo = New FileInfo(Me.sourceAccessDatabase)
                _accessApplication.OpenCurrentDatabase(fdb.FullName, False)
            End If

            Console.WriteLine("Open database {0} sucessfull.", fiAccess.FullName)

        Catch ex As Exception
            Me.closeAndReleaseAccessCOM()

            Throw ex

        End Try

    End Sub

    Public Function convertForm(fname As String) As Boolean

        Dim c As Object 'Access.Control

        Try
            AccessConversionContext.current.processedControls.Clear()
            Me.AccessApplication.DoCmd.OpenForm(fname, 1) '1 = Access.AcFormView.acDesign
            _accessForm = Me.AccessApplication.Forms(fname)

            If AccessForm.DefaultView = 1 Then
                'default view is "Continious forms
                'for the moment not supported
                Console.WriteLine("****STOP: Continuous Forms not supported.")
                Return False
            End If

            Dim fdotnet As New AccessDotNetConverter.AccessToDotNetForm
            fdotnet.accessControl = AccessForm

            Dim code As String = fdotnet.getDotNetDesignerCode()
            Dim formDotNetName As String = fdotnet.dotNetName

            Dim dotNetFilePath As String = Me.dotNetProjectPath & _
                        formDotNetName & ".Designer." & Me.convertedFilesExtension

            File.WriteAllText(dotNetFilePath, _
                                code, _
                                System.Text.Encoding.UTF8)


            Console.WriteLine("Wrote File {0}", dotNetFilePath)
            code = fdotnet.getDotNetClassCode()
            dotNetFilePath = Me.dotNetProjectPath & _
                        formDotNetName & "." & Me.convertedFilesExtension
            File.WriteAllText(dotNetFilePath, _
                                code, _
                                System.Text.Encoding.UTF8)
            Console.WriteLine("Wrote File {0}", dotNetFilePath)

            Return True
        Finally
            _accessForm = Nothing
            c = Nothing

            Me.closeAndReleaseAccessCOM()

        End Try

    End Function

    ''' <summary>
    ''' Returns a list of the names in the open access database
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getAllAccessForms() As List(Of String)

        Dim frm As Object = Nothing 'Access.Form
        Dim ret As New List(Of String)
        Dim allAccForms As Object = Nothing
        Dim conts As Object = Nothing

        Try
            Me.openAccessDatabase()

            'CurrentProject.AllForms returns the form collection of both MDBs or ADPs
            allAccForms = _accessApplication.CurrentProject.AllForms()

            If allAccForms Is Nothing Then Return Nothing

            For Each frm In allAccForms

                ret.Add(frm.name)

            Next

        Finally
            frm = Nothing
            allAccForms = Nothing
            conts = Nothing

            Me.closeAndReleaseAccessCOM()
        End Try

        Return ret

    End Function

    ''' <summary>
    ''' Closes and releases the MS Access COM reference
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub closeAndReleaseAccessCOM()
        If _accessApplication IsNot Nothing Then
            _accessApplication.CloseCurrentDatabase()
            _accessApplication.Quit(2) 'acQuitSaveNone
            Marshal.FinalReleaseComObject(_accessApplication)
        End If

        _accessApplication = Nothing
    End Sub

    Sub updateConfig(configFile As FileInfo, accessDatabase As String, dotNetProjectPath As String)

        Dim emnt As XElement = AccessConversionContext.current.Config.Element("AccessToDotNetConfig")
        emnt.Attribute("sourceAccessDatabase").Value = accessDatabase
        emnt.Attribute("targetDotNetProjectPath").Value = dotNetProjectPath
        AccessConversionContext.current.Config.Save(configFile.FullName)

    End Sub

    ReadOnly Property ProjectName() As String
        Get
            Return _ProjectName
        End Get
    End Property


    ''' <summary>
    ''' Gets The current access form being converted
    ''' </summary>
    ''' <remarks></remarks>
    Public ReadOnly Property AccessForm() As Object
        Get
            Return _accessForm
        End Get
    End Property

   

End Class
