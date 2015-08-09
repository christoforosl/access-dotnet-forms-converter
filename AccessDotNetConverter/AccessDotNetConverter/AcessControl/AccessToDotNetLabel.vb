
Public Class AccessToDotNetLabel
    Inherits AccessToDotNetControl

    Public Overrides ReadOnly Property dotNetType() As String
        Get
            Return IIf(String.IsNullOrEmpty(MyBase.dotNetType), "Label", MyBase.dotNetType)
        End Get

    End Property

    Public Overrides Function getControlLayoutCode() As String

        Dim thisCtrl = MyBase.getControlLayoutCode()
        thisCtrl = thisCtrl & vbCrLf & AccessConversionContext.current.thisOrMe & "." & dotNetInstanceName & ".TextAlign="

        If Me.accessControl.textalign = 2 Then 'center
            thisCtrl = thisCtrl & "System.Drawing.ContentAlignment.MiddleCenter"
        ElseIf Me.accessControl.textalign = 3 Then 'right
            thisCtrl = thisCtrl & "System.Drawing.ContentAlignment.MiddleRight"
        Else
            thisCtrl = thisCtrl & "System.Drawing.ContentAlignment.MiddleLeft"
        End If
        thisCtrl = thisCtrl & AccessConversionContext.current.LineEnding

        thisCtrl = thisCtrl & AccessConversionContext.current.thisOrMeDot & _
                dotNetInstanceName & ".Text = " & exNetText(Me.accessControl.Caption) & AccessConversionContext.current.LineEnding

        If Me.accessControl.ForeColor <> 0 Then
            thisCtrl = thisCtrl & AccessConversionContext.current.thisOrMeDot & dotNetInstanceName & _
                    ".ForeColor = System.Drawing.ColorTranslator.FromOle(" & Me.accessControl.ForeColor & ")" & AccessConversionContext.current.LineEnding
        End If


        If Me.accessControl.BackStyle <> 0 Then
            thisCtrl = thisCtrl & AccessConversionContext.current.thisOrMeDot & dotNetInstanceName & _
                ".BackColor = System.Drawing.ColorTranslator.FromOle(" & Me.accessControl.BackColor & ")" & AccessConversionContext.current.LineEnding
        End If

        thisCtrl = thisCtrl & vbCrLf
        Return thisCtrl

    End Function

End Class