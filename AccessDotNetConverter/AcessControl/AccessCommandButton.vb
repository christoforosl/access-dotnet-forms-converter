Imports System.IO
Imports System.Text

Public Class AccessToDotNetCommandButton
    Inherits AccessToDotNetControl

    Public Overrides Function getControlLayoutCode() As String


        If Not IsDBNull(Me.accessControl.pictureData) Then
            'imagetest.SavePicture712(Me.accessControl.pictureData)

            'Dim pic As New FileInfo("..\..\" & Me.accessControl.name & ".PNG")
            'Dim pic As stdole.IPictureDisp
            'pic = AccessConversionContext.current.AccessApp.SysCmd(712, Me.accessControl)

            'Dim img As Image
            ''Dim picbytes() As Byte = ConvertOleBytesToRawBytes(Me.accessControl.pictureData)
            'Dim picbytes() As Byte = Me.accessControl.pictureData
            'Dim txt As String = System.Text.Encoding.GetEncoding(1252).GetString(picbytes)
            'ms.Seek(0, SeekOrigin.Begin)
            'Dim bmp As Bitmap = New Bitmap(ms)

            'img = Image.FromStream(ms, False, False)
            'img.Save(pic.FullName)

            'ms.Close()

            ' File.WriteAllText(pic.FullName, txt)
        End If

        Dim thisCtrl = MyBase.getControlLayoutCode()



        thisCtrl = thisCtrl & vbCrLf & "Me." & dotNetInstanceName & ".Text = " & exNetText(Me.accessControl.Caption)
        If Me.accessControl.ForeColor <> 0 Then
            thisCtrl = thisCtrl & vbCrLf & "Me." & _
                dotNetInstanceName & ".forecolor = System.Drawing.ColorTranslator.FromOle(" & _
                Me.accessControl.ForeColor & ")"
        End If

        Return thisCtrl

    End Function


    Public Shared Function ConvertOleBytesToRawBytes(oleBytes As Byte()) As Byte()

        ' The default encoding is in my case - Western European (Windows), Code Page 1252
        Return Encoding.Convert(Encoding.Default, Encoding.Unicode, oleBytes)

    End Function



End Class
