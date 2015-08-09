Public Class AccessToDotNetTabPage
    Inherits AccessToDotNetControl

    Public Overrides Function getControlInstantiationCode() As String

        Return MyBase.getControlInstantiationCode() & _
            "Me." & dotNetInstanceName & ".SuspendLayout()" & vbCrLf

    End Function

    Public Overrides Function getControlLayoutCode() As String

        Return MyBase.getControlLayoutCode() & _
            vbCrLf & AccessConversionContext.current.thisOrMe & "." & dotNetInstanceName & ".Text = """ & Me.accessControl.Caption & """" & vbCrLf

    End Function

End Class
