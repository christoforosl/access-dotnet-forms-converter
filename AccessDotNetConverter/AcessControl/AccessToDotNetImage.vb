Imports System.Text

Public Class AccessToDotNetImage
    Inherits AccessToDotNetControl

    Public Overrides Function getControlLayoutCode() As String

        Dim ret As StringBuilder = New StringBuilder(MyBase.getControlLayoutCode())
        'Dim o As Object = AccessConversionContext.current.AccessApplication.SysCmd(712, Me.accessControl)
        'Dim img As System.Drawing.Image = IconConverter.GetNetPictureFromIPicture(o)
        'img.Save(AccessConversionContext.current.dotNetProjectPath & Me.accessControl.name)

        'ret.Append("Me.ImageLocaltion= " & AccessConversionContext.current.dotNetProjectPath & Me.accessControl.name)

        Return ret.ToString

    End Function

End Class