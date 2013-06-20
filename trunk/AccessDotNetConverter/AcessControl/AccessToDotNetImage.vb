Imports System.Text
Imports Microsoft.Office.Interop

Public Class AccessToDotNetImage
    Inherits AccessToDotNetControl

    Public Overrides Function getControlLayoutCode() As String

        Dim accAppl As Object = AccessConversionContext.current.AccessApplication
        Dim accFormName As String = AccessConversionContext.current.AccessForm.name

        Try

            Dim ret As StringBuilder = New StringBuilder(MyBase.getControlLayoutCode())

            'imagetest.SavePicture712(Me.accessControl.pictureData)

            'Dim evalCode As String = String.Format("Dim o as object" & vbCrLf & _
            '                                       "set o = SysCmd(712,forms(""{0}"").{1})" & vbCrLf & _
            '                                       "Call stdole.SavePicture(o, ""c:\users\chris\test.emf"")", _
            '                                        AccessConversionContext.current.AccessForm.name, _
            '                                        Me.accessControl.name)
            'Call accAppl.eval(evalCode)
            'Dim c As Access.Image = accAppl.forms(accFormName).Controls(Me.accessControl.name)
            'Dim assapp As Access.Application = AccessConversionContext.current.AccessApplication
            'Dim o As stdole.IPictureDisp = accAppl.SysCmd(712, c.Name)

            'Dim img As System.Drawing.Image = IconConverter.GetNetPictureFromIPicture(o)
            ''img.Save(AccessConversionContext.current.dotNetProjectPath & Me.accessControl.name)

            ''ret.Append("Me.ImageLocaltion= " & AccessConversionContext.current.dotNetProjectPath & Me.accessControl.name)

            Return ret.ToString

        Finally
            accAppl = Nothing

        End Try

    End Function

End Class