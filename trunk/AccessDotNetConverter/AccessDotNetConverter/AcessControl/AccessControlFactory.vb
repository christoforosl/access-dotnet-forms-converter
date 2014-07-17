
Imports AccessDotNetConverter.My
Imports System.Reflection

Public Class AccessControlFactory

    Public Shared Function getAccessToDotNetControl(accessControl As Object) As AccessToDotNetControl
        ' c = Access.Control
        Dim x As XDocument = AccessConversionContext.current.Config
        Dim ret As AccessToDotNetControl = Nothing

        Dim lXElements As IEnumerable(Of XElement) = x.Element("AccessToDotNetConfig"). _
                Element("controlmaps"). _
                Elements("controlmap")

        For Each elmnt As XElement In lXElements
            '[Enum].Parse(Access.AcControlType.

            Dim ctrlType As String = [Enum].GetName(GetType(AcControlType), accessControl.controltype)

            If ctrlType = elmnt.Attribute("accessType").Value Then

                If elmnt.Attribute("handler") IsNot Nothing Then

                    If String.IsNullOrEmpty(elmnt.Attribute("handler").Value) Then
                        'return nothing: ie we do not handle this control
                    Else
                        If elmnt.Attribute("nameMatch") IsNot Nothing AndAlso _
                                (Not String.IsNullOrEmpty(elmnt.Attribute("nameMatch").Value)) Then
                            Dim regex As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex(elmnt.Attribute("nameMatch").Value)
                            If regex.IsMatch(accessControl.name) Then
                                Dim handlerClass As String = elmnt.Attribute("handler").Value
                                ret = Activator.CreateInstance(Type.GetType(handlerClass))
                            End If
                        Else
                            Dim handlerClass As String = elmnt.Attribute("handler").Value
                            ret = Activator.CreateInstance(Type.GetType(handlerClass))
                        End If

                    End If

                Else
                    ret = New AccessToDotNetControl
                End If


            End If
        Next

        If ret IsNot Nothing Then
            ret.accessControl = accessControl
        End If

        Return ret

    End Function

End Class
