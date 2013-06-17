Imports AccessDotNetConverter.My
Imports System.Text
Imports Microsoft.VisualBasic.Compatibility


Public Class AccessToDotNetLine
    Inherits AccessToDotNetControl

    Public Overrides Function getControlLayoutCode() As String

        Dim ctlCode As StringBuilder = New StringBuilder()

        ctlCode.Append(vbCrLf).Append(AccessToDotNetControl.ME_DOT).Append(Me.dotNetInstanceName).Append(".Name = """).Append(Me.dotNetInstanceName).Append("""")
        ctlCode.Append(vbCrLf).Append(AccessToDotNetControl.ME_DOT).Append(Me.dotNetInstanceName).Append(".X1=").Append(TwipsToPixelsX(Me.accessControl.left))
        ctlCode.Append(vbCrLf).Append(AccessToDotNetControl.ME_DOT).Append(Me.dotNetInstanceName).Append(".X2=").Append(TwipsToPixelsX(Me.accessControl.left + Me.accessControl.width))
        ctlCode.Append(vbCrLf).Append(AccessToDotNetControl.ME_DOT).Append(Me.dotNetInstanceName).Append(".Y1=").Append(TwipsToPixelsY(Me.accessControl.top))
        ctlCode.Append(vbCrLf).Append(AccessToDotNetControl.ME_DOT).Append(Me.dotNetInstanceName).Append(".Y2=").Append(TwipsToPixelsY(Me.accessControl.top + Me.accessControl.height))

        Return ctlCode.ToString

    End Function
End Class
