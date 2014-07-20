Imports AccessDotNetConverter.My
Imports System.Text
Imports Microsoft.VisualBasic.Compatibility
Imports System.Text.RegularExpressions

Public Class AccessToDotNetControl

    Public Const ME_DOT As String = "Me."

    ''' <summary>
    ''' The parent control of the current control.
    ''' This is to satisfy the classic control hierarchy on Microsoft windows
    ''' </summary>
    Public Property ParentControl As AccessToDotNetControl

    ''' <summary>
    ''' The control declaration code.
    ''' For example: 
    ''' Friend WithEvents xx As Textbox
    ''' </summary>
    Public Property controlDeclarationCode As StringBuilder = New StringBuilder()

    ''' <summary>
    ''' This is the object properties set to control the appearance, position, size, etc of the control
    ''' </summary>
    Public Property controlLayoutCode As StringBuilder = New StringBuilder()

    ''' <summary>
    ''' The code generated to add the control on to its parent control
    ''' </summary>
    Public Property controlAddCode As StringBuilder = New StringBuilder()

    ''' <summary>
    ''' The code generated to instantiate the control. For example:
    ''' <code>xx = New Textbox</code>
    ''' </summary>
    Public Property controlInstantiationCode As StringBuilder = New StringBuilder()

    ''' <summary>
    ''' A reference to the Access Control that will be converted to a .net control
    ''' </summary>
    Private _accessControl As Object ' Access.Control

    ''' <summary>
    ''' The .Net instance name of the access control.
    ''' </summary>
    Private _dotNetInstanceName As String = Nothing

    Private _dotNetName As String

    ''' <summary>
    ''' The .Net type of the access control.
    ''' </summary>
    Private _dotNetType As String

    Private _IAccessToDotNetControlCodeGenerator As IAccessToDotNetControlCodeConverter

    Public Property accessToDotNetControlCodeGenerator As IAccessToDotNetControlCodeConverter
        Get
            If (_IAccessToDotNetControlCodeGenerator Is Nothing) Then
                _IAccessToDotNetControlCodeGenerator = New AccessToDotNetControlCodeConverter
            End If
            Return _IAccessToDotNetControlCodeGenerator
        End Get

        Set(value As IAccessToDotNetControlCodeConverter)
            _IAccessToDotNetControlCodeGenerator = value
        End Set
    End Property

    Public Sub convertCode()

        Me.accessToDotNetControlCodeGenerator.convertCode(Me)

    End Sub

    Public Overridable ReadOnly Property getChildControls As Object
        Get
            Return Me.accessControl.Controls
        End Get
    End Property

    Public Overridable ReadOnly Property acControlType As AcControlType
        Get
            Return _accessControl.controlType
        End Get
    End Property

    ''' <summary>
    ''' The name of the control, as it is in Access
    ''' </summary>
    ''' <remarks>
    ''' To modify rules of control names, write a class that implements interface INamingHandler
    ''' and specify it in the configuration file  
    '''</remarks>
    Public ReadOnly Property Name As String
        Get
            Return _accessControl.Name
        End Get
    End Property

    Private _dotnetParentControlName As String

    ''' <summary>
    ''' Strign Property used to prefix controls addition.
    ''' For example, for control "EmployeeTypeID", on Form then we 
    ''' probably want this to return "Me."
    ''' Me.Controls.Add(Me.EmployeeTypeID)
    ''' 
    ''' For example, for control "EmployeeTypeID", that is on a panel cotrol called "panel1" then we 
    ''' want this to return "panel1."
    ''' panel1.Controls.Add(Me.EmployeeTypeID)
    ''' </summary>
    Public Overridable ReadOnly Property dotnetParentControlName As String
        Get

            If _dotnetParentControlName Is Nothing Then
                If TypeOf Me.ParentControl Is AccessToDotNetForm Then
                    Dim x As XDocument = AccessConversionContext.current.Config
                    Dim configElement As XElement = x.Element("AccessToDotNetConfig").Element("controlmaps")

                    For Each elmnt As XElement In configElement.Elements
                        If [Enum].Parse(acControlType.GetType, elmnt.Attribute("accessType")) = acControlType.acForm Then
                            
                            If elmnt.Attribute("nameMatch") IsNot Nothing AndAlso _
                                        (Not String.IsNullOrEmpty(elmnt.Attribute("nameMatch").Value)) Then
                                Dim regex As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex(elmnt.Attribute("nameMatch").Value)
                                If regex.IsMatch(accessControl.name) Then
                                    If elmnt.Attribute("rootControl") IsNot Nothing Then
                                        _dotnetParentControlName = elmnt.Attribute("rootControl").Value
                                        Exit For
                                    End If
                                End If
                            Else
                                If elmnt.Attribute("rootControl") IsNot Nothing Then
                                    _dotnetParentControlName = elmnt.Attribute("rootControl").Value
                                    Exit For
                                End If
                            End If
                        End If
                    Next

                    If _dotnetParentControlName Is Nothing Then
                        _dotnetParentControlName = "Me"
                    End If

                    If _dotnetParentControlName.EndsWith(".") Then
                        _dotnetParentControlName.Substring(0, _dotnetParentControlName.Length - 1)
                    End If

                End If
            Else
                _dotnetParentControlName = Me.ParentControl.dotNetInstanceName
            End If

            Return _dotnetParentControlName

        End Get
    End Property


    ''' <summary>
    ''' The instance name if the control in .NET
    ''' </summary>
    ''' <remarks>
    ''' For any object whose parent is null, this method will return "Me".
    ''' For all other controls, the name of the control
    ''' </remarks>
    Public Overridable ReadOnly Property dotNetInstanceName As String
        Get

            If Me.ParentControl Is Nothing Then
                Return "Me"
            Else
                If _dotNetInstanceName Is Nothing Then
                    _dotNetInstanceName = AccessConversionContext.current.ControlsNameHandler.getDotNetname(Me.Name)
                End If
                Return _dotNetInstanceName
            End If

        End Get
    End Property


    ''' <summary>
    ''' The name if the control in .NET
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    Public Overridable ReadOnly Property dotNetName As String
        Get
            Return _dotNetName
        End Get
    End Property

    Public Property accessControl As Object ' Access.Control
        Get
            Return _accessControl
        End Get
        Set(value As Object)
            _accessControl = value
            _dotNetName = AccessConversionContext.current.ControlsNameHandler.getDotNetname(Me._accessControl.name)

            Dim x As XDocument = AccessConversionContext.current.Config

            Dim lXElements As IEnumerable(Of XElement) = x.Element("AccessToDotNetConfig"). _
                    Element("controlmaps"). _
                    Elements("controlmap")

            For Each elmnt As XElement In lXElements
                If Me.acControlType.ToString = elmnt.Attribute("accessType").Value Then
                    _dotNetType = elmnt.Attribute("dotnetType").Value
                End If

            Next

        End Set
    End Property


    Public Function exNetText(ByVal scaption As String) As String

        Dim caption As String = Replace(scaption, Chr(34), Chr(34) & Chr(34))
        caption = Chr(34) & Replace(scaption, vbCrLf, Chr(34) & " & vbCrLf & " & Chr(34)) & Chr(34)
        Return caption

    End Function

    Public Shared Function TwipsToPixelsX(twips As Integer) As Integer
        Return CInt(VB6.Support.TwipsToPixelsX(twips))
    End Function

    Public Shared Function TwipsToPixelsY(twips As Integer) As Integer
        Return CInt(VB6.Support.TwipsToPixelsY(twips))
    End Function

    Private Function GetControlTop() As Object

        Return TwipsToPixelsY(accessControl.top) + Me.getContainerOffsetTop

    End Function

    Public Overridable Function getControlLayoutCode() As String

        Dim ctlCode As StringBuilder = New StringBuilder(vbCrLf).Append(ME_DOT). _
                            Append(Me.dotNetInstanceName).Append(".Name = """).Append(Me.dotNetInstanceName).Append("""")
        ctlCode.Append(vbCrLf).Append(ME_DOT).Append(Me.dotNetInstanceName). _
                Append(".Location = New System.Drawing.Point(").Append(TwipsToPixelsX(accessControl.left)). _
                Append(", ").Append(GetControlTop() & ")")

        ctlCode.Append(vbCrLf).Append(ME_DOT).Append(Me.dotNetInstanceName). _
                Append(".Size = New System.Drawing.Size(").Append(Me.dotNetControlWidth).Append(", "). _
                Append(Me.dotNetControlHeight).Append(")")

        ctlCode.Append(vbCrLf).Append(ME_DOT).Append(Me.dotNetInstanceName). _
                Append(".Visible=").Append(accessControl.visible)

        If hasTabIndex() Then
            ctlCode.Append(vbCrLf).Append("me.").Append(Me.dotNetInstanceName). _
                Append(".TabIndex = ").Append(Me.accessControl.TabIndex)
        End If

        If hasFont() Then

            Dim sFont As String = "Regular"

            If Me.accessControl.FontBold = 1 Then
                sFont = "Bold"
            End If
            ctlCode.Append(vbCrLf).Append("me." & dotNetInstanceName).Append(".Font = New System.Drawing.Font(""").Append( _
                        Me.accessControl.FontName).Append(""", ").Append(Me.accessControl.FontSize & "!, System.Drawing.FontStyle.").Append( _
                        sFont).Append(", System.Drawing.GraphicsUnit.Point, CType(161, Byte))")
        End If

        Return ctlCode.ToString

    End Function

    ''' <summary>
    ''' Returns the access label associated with this control
    ''' </summary>
    Public Function getControlLabel() As Object 'aclabel

        If Me.acControlType = AccessDotNetConverter.AcControlType.acForm Then Return Nothing

        Dim child As Object

        For i As Integer = 0 To Me.accessControl.Controls.Count
            child = Me.accessControl.Controls.Item(i)
            If child.ControlType = acControlType.acLabel Then
                Return child
            End If
        Next
        Return Nothing

    End Function

    Public Overridable Function getControlDeclarationCode() As String

        If Me.acControlType = AccessDotNetConverter.AcControlType.acForm Then
            Return String.Empty
        End If

        Return String.Format("Friend WithEvents {0} As {1}", dotNetInstanceName, Me.dotNetType) & vbCrLf

    End Function

    Public Overridable Function getControlInstantiationCode() As String

        If Me.acControlType = AccessDotNetConverter.AcControlType.acForm Then
            Return String.Empty
        End If

        Return ME_DOT & Me.dotNetInstanceName & " = New " & Me.dotNetType & vbCrLf

    End Function

    ''' <summary>
    ''' Returns the code required to add the control to its contaner
    ''' For example, for a control with name "FirstName", with parent the Form, this function will return 
    ''' <pre>me.Controls.Add(me.FirstName)</pre>
    ''' 
    ''' For example, for a control with name "FirstName", with parent a tab control named "InfoTab", this function will return 
    ''' <pre>me.InfoTab.Controls.Add(me.FirstName)</pre>
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overridable Function getControlAddToContainerCode() As String
        If Me.acControlType = AccessDotNetConverter.AcControlType.acForm Then
            Return String.Empty
        End If

        Return vbCrLf & Me.dotnetParentControlName & _
                ".controls.add(me." & Me.dotNetInstanceName & ")"

    End Function

    Public Overridable ReadOnly Property dotNetType() As String

        Get
            Return _dotNetType
        End Get

    End Property

    Public Function isContainer() As Boolean

        Return Me.acControlType = acControlType.acForm OrElse Me.acControlType = acControlType.acTabCtl OrElse _
            Me.acControlType = acControlType.acPage

    End Function

    Public Function getContainerOffsetTop() As Integer
        'MS Access controls on tab have their "Top" property relative to the Tab control Start point.
        'In net, controls on tab have their "Top" property relative to the Tab Page Start point.
        'so we offset by 100 pixels to push controls up
        If Me.ParentControl.acControlType = acControlType.acPage Then
            Return -30
        Else
            Return 0
        End If


    End Function

    Private Function hasTabIndex() As Boolean

        Return Me.acControlType <> acControlType.acLabel AndAlso _
                Me.acControlType <> acControlType.acLine AndAlso _
                Me.acControlType <> acControlType.acImage AndAlso _
                    Me.acControlType <> acControlType.acRectangle AndAlso _
                    Me.acControlType <> acControlType.acPage AndAlso _
                    Me.acControlType <> acControlType.acOptionGroup

    End Function

    Private Function hasFont() As Boolean
        Return Me.acControlType <> acControlType.acCheckBox AndAlso _
                Me.acControlType <> acControlType.acLine AndAlso _
                    Me.acControlType <> acControlType.acRectangle AndAlso _
                     Me.acControlType <> acControlType.acImage AndAlso _
                    Me.acControlType <> acControlType.acOptionGroup AndAlso _
                    Me.acControlType <> acControlType.acPage AndAlso _
                    Me.acControlType <> acControlType.acCustomControl

    End Function

    Overridable Function dotNetControlWidth() As Integer
        If Me.accessControl.controlType = acControlType.acCheckBox Then
            Return 14
        End If

        Return TwipsToPixelsY(accessControl.Width)
    End Function

    Overridable Function dotNetControlHeight() As Integer

        If Me.accessControl.controlType = acControlType.acCheckBox Then
            Return 14
        End If

        Return TwipsToPixelsX(accessControl.Height)
    End Function



End Class

