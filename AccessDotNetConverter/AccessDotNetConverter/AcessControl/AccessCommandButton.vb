Imports System.IO
Imports System.Text

Public Class AccessToDotNetCommandButton
    Inherits AccessToDotNetControl

    Public Overrides Function getControlLayoutCode() As String


        If Not IsDBNull(Me.accessControl.pictureData) Then
            ImageConverter.SavePictureData(Me.accessControl.pictureData, Me.accessControl.name)

        End If

        Dim thisCtrl = MyBase.getControlLayoutCode()

        thisCtrl = thisCtrl & AccessConversionContext.current.thisOrMeDot & dotNetInstanceName & ".Text = " & _
                exNetText(Me.accessControl.Caption) & AccessConversionContext.current.LineEnding

        If Me.accessControl.ForeColor <> 0 Then
            thisCtrl = thisCtrl & AccessConversionContext.current.thisOrMeDot & "." & _
                dotNetInstanceName & ".forecolor = System.Drawing.ColorTranslator.FromOle(" & _
                Me.accessControl.ForeColor & ")" & AccessConversionContext.current.LineEnding
        End If

        Return thisCtrl

    End Function


    Public Shared Function ConvertOleBytesToRawBytes(oleBytes As Byte()) As Byte()

        ' The default encoding is in my case - Western European (Windows), Code Page 1252
        Return Encoding.Convert(Encoding.Default, Encoding.Unicode, oleBytes)

    End Function



End Class
