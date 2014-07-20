
Public Interface IAccessToDotNetControlCodeConverter

    Sub convertCode(ac As AccessToDotNetControl)

End Interface

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class AccessToDotNetControlCodeConverter
    Implements IAccessToDotNetControlCodeConverter

    Public Sub convertCode(ac As AccessToDotNetControl) Implements IAccessToDotNetControlCodeConverter.convertCode

        Console.WriteLine("Control {0} now processing", ac.accessControl.name)
        ac.controlDeclarationCode.Append(ac.getControlDeclarationCode)
        ac.controlLayoutCode.Append(ac.getControlLayoutCode)
        ac.controlAddCode.Append(ac.getControlAddToContainerCode)
        ac.controlInstantiationCode.Append(ac.getControlInstantiationCode)

        If Not ac.isContainer Then Exit Sub

        Dim controlsCollection As Object = ac.getChildControls
        Console.WriteLine("Child Controls of {0} now processing", ac.accessControl.name)

        'currentControl is a reference to an Access Control
        For Each currentControl As Object In controlsCollection
            Dim adc As AccessToDotNetControl = AccessControlFactory.getAccessToDotNetControl(currentControl)
            If adc Is Nothing Then
                Console.WriteLine("Control name ""{0}"" of type ""{1}"" not handled", _
                                currentControl.name, _
                                currentControl.controltype)
            Else

                If AccessConversionContext.current.processedControls.Contains(currentControl.name) Then
                    'access returns the control collection both in a flat and hierchical way
                    Console.WriteLine("Control {0} of type {1} altready processed", currentControl.Name, currentControl.ControlType)
                Else
                    adc.ParentControl = ac

                    Call adc.convertCode()
                    ac.controlDeclarationCode.Append(adc.controlDeclarationCode)
                    ac.controlLayoutCode.Append(adc.controlLayoutCode)
                    ac.controlAddCode.Append(adc.controlAddCode)
                    ac.controlInstantiationCode.Append(adc.controlInstantiationCode)

                    AccessConversionContext.current.processedControls.Add(currentControl.name)

                End If
            End If
        Next
    End Sub


End Class
