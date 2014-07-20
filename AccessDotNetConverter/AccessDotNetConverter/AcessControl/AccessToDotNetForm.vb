Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Text

Public Class AccessToDotNetForm
    Inherits AccessToDotNetControl

    Private _templateCode As String = Nothing

    Public Overrides ReadOnly Property acControlType As AcControlType
        Get
            Return acControlType.acForm
        End Get
    End Property

    Public Property templateCode As String
        Get

            If _templateCode Is Nothing Then
                _templateCode = Me.loadTemplateCode
            End If
            Return _templateCode
        End Get
        Set(value As String)
            _templateCode = value
        End Set
    End Property

    Public Overrides Function getControlLayoutCode() As String
        Return String.Empty
    End Function

    Private Function loadTemplateCode() As String

        Dim x As XDocument = AccessConversionContext.current.Config
        Dim configElement As XElement = x.Element("AccessToDotNetConfig")
        Dim templateFile As String = configElement.Attribute("defaultBaseFormTemplate")

        Dim value As String = File.ReadAllText(templateFile)

        Return value

    End Function

    Function getDotNetDesignerCode() As String

        Me.convertCode()

        Dim formCode As String = Me.templateCode
        Dim formName As String = AccessConversionContext.current.ControlsNameHandler.getDotNetname(Me.Name)
        formCode = Replace(formCode, "<__DATETIME__>", Format(Now, "Long Date"))
        formCode = Replace(formCode, "<__form_name__>", formName)
        formCode = Replace(formCode, "<__form_caption__>", Me.accessControl.Caption)
        formCode = Replace(formCode, "<__INHERITS__>", Me.getInherits)

        formCode = Replace(formCode, "<__ADD_CONTROLS__>", Me.controlAddCode.ToString)
        formCode = Replace(formCode, "<__CONTROL__LAYOUT__>", Me.controlLayoutCode.ToString)

        formCode = Replace(formCode, "<__CONTROL__DECL__>", Me.controlDeclarationCode.ToString)
        formCode = Replace(formCode, "<__CONTROL__CREATE__>", Me.controlInstantiationCode.ToString)
        formCode = Replace(formCode, "<__h__>", AccessToDotNetControl.TwipsToPixelsY(Me.accessControl.InsideHeight))
        formCode = Replace(formCode, "<__w__>", AccessToDotNetControl.TwipsToPixelsX(Me.accessControl.InsideWidth))
        Return formCode

    End Function

    Private Function getInherits() As String

        Dim x As XDocument = AccessConversionContext.current.Config
        Dim configElement As XElement = x.Element("AccessToDotNetConfig").Element("controlmaps")

        For Each mapo As XElement In configElement.Elements
            If [Enum].Parse(acControlType.GetType, mapo.Attribute("accessType")) = acControlType.acForm Then
                If mapo.Attribute("nameMatch") IsNot Nothing Then
                    Dim regex As Regex = New Regex(mapo.Attribute("nameMatch").Value)
                    If regex.IsMatch(Me.accessControl.name) Then
                        Return mapo.Attribute("dotnetType").Value
                    End If
                Else
                    Return mapo.Attribute("dotnetType").Value
                End If
            End If
        Next
        Return AccessConversionContext.current.defaultBaseForm

    End Function

    Function getDotNetClassCode() As String

        Return "Public Class " & Me.dotNetName & vbCrLf & _
            "End Class"

    End Function

    Public Overrides ReadOnly Property getChildControls As Object
        Get
            Return Me.accessControl.Section(0).Controls()
        End Get
    End Property

    

End Class
