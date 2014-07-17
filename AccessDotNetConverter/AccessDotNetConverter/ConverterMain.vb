Public Class ConverterMain

    Public Const STR_REG_APPL As String = "AccessDotNetConverter"
    Public Const STR_REG_SECTION As String = "Settings"

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
    Public Shared Function checkCommandLine() As Boolean

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
End Class
