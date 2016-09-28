Public Class AccessToDotNetTabPage
    Inherits AccessToDotNetControl

    Public Overrides Function getControlInstantiationCode() As String

		Return MyBase.getControlInstantiationCode() & _
		 AccessConversionContext.current.thisOrMe & dotNetInstanceName & ".SuspendLayout()" & AccessConversionContext.current.LineEnding & vbCrLf

    End Function

    Public Overrides Function getControlLayoutCode() As String

		Return MyBase.getControlLayoutCode() & _
			vbCrLf & AccessConversionContext.current.thisOrMe & "." & dotNetInstanceName & ".Text = """ & Me.accessControl.Caption & """" & AccessConversionContext.current.LineEnding & vbCrLf

    End Function

End Class
