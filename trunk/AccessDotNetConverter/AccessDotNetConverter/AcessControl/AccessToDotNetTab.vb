
Public Class AccessToDotNetTab
    Inherits AccessToDotNetControl

    ''' <summary>
    ''' The tab cobtrol does not have a "childControls" property so we use the "Pages" property
    ''' </summary>
    Public Overrides ReadOnly Property getChildControls As Object
        Get
            Return Me.accessControl.Pages
        End Get
    End Property

    Public Overrides Function getControlInstantiationCode() As String

        Return MyBase.getControlInstantiationCode() & _
            vbCrLf & "Me." & dotNetInstanceName & ".SuspendLayout()" & vbCrLf

    End Function

End Class
