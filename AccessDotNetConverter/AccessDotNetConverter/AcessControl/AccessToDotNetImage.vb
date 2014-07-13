Imports System.Text

Public Class AccessToDotNetImage
    Inherits AccessToDotNetControl

    Public Overrides Function getControlLayoutCode() As String

        Dim accAppl As Object = AccessConversionContext.current.AccessApplication
        Dim accFormName As String = AccessConversionContext.current.AccessForm.name

        Try

            Dim ret As StringBuilder = New StringBuilder(MyBase.getControlLayoutCode())

            ImageConverter.SavePictureData(Me.accessControl.pictureData, Me.accessControl.name)

            Return ret.ToString

        Finally
            accAppl = Nothing

        End Try

    End Function

End Class