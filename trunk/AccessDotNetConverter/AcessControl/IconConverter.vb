Imports System.IO
Imports System.Text


Public Class IconConverter
    Inherits System.Windows.Forms.AxHost

    Private Sub New()
        MyBase.new(String.Empty)
    End Sub


    Public Shared Function GetIPictureDispFromNetPicture2(image As System.Drawing.Image) As stdole.IPictureDisp

        Return CType(GetIPictureDispFromPicture(image), stdole.IPictureDisp)

    End Function
    Public Shared Function GetNetPictureFromIPicture(pic As Object) As System.Drawing.Image

        Return CType(GetPictureFromIPicture(pic), System.Drawing.Image)

    End Function


End Class
