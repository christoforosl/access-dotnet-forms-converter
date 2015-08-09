Imports AccessDotNetConverter.My
Imports System.Text
Imports Microsoft.VisualBasic.Compatibility


Public Class AccessToDotNetLine
    Inherits AccessToDotNetControl

    Public Overrides Function getControlLayoutCode() As String

        Dim ctlCode As StringBuilder = New StringBuilder()

        ctlCode.Append(AccessConversionContext.current.thisOrMe).Append(Me.dotNetInstanceName).Append(".Name = """).Append(Me.dotNetInstanceName).Append("""").Append(AccessConversionContext.current.LineEnding)
        ctlCode.Append(AccessConversionContext.current.thisOrMe).Append(Me.dotNetInstanceName).Append(".X1=").Append(TwipsToPixelsX(Me.accessControl.left)).Append(AccessConversionContext.current.LineEnding)
        ctlCode.Append(AccessConversionContext.current.thisOrMe).Append(Me.dotNetInstanceName).Append(".X2=").Append(TwipsToPixelsX(Me.accessControl.left + Me.accessControl.width)).Append(AccessConversionContext.current.LineEnding)
        ctlCode.Append(AccessConversionContext.current.thisOrMe).Append(Me.dotNetInstanceName).Append(".Y1=").Append(TwipsToPixelsY(Me.accessControl.top)).Append(AccessConversionContext.current.LineEnding)
        ctlCode.Append(AccessConversionContext.current.thisOrMe).Append(Me.dotNetInstanceName).Append(".Y2=").Append(TwipsToPixelsY(Me.accessControl.top + Me.accessControl.height)).Append(AccessConversionContext.current.LineEnding)

        Return ctlCode.ToString

    End Function
End Class
