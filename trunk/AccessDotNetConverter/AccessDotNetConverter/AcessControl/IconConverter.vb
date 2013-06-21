Imports System.IO
Imports System.Text
Imports System.Runtime.InteropServices

''' <summary>
''' Some parts taken from http://www.lebans.com/imagecontroltoclipboard.htm
''' </summary>
''' <remarks></remarks>
Public Module ImageConverter

    ' ClipBoard Formats
    Private Const CF_BITMAP = 2
    Private Const CF_DIB = 8
    Private Const CF_ENHMETAFILE = 14
    Private Const CF_METAFILEPICT = 3

    Public Sub SavePictureData(ByVal picData As Byte(), ByVal ctrlname As String)

        'HOW IT WORKS:
        ' The first 8 Bytes of a PictureData prop signify
        ' that the data is structured as one of the
        ' following ClipBoard Formats.
        ' CF_DIB
        ' CF_ENHMETAFILE
        ' CF_METAFILEPICT
        ' If the first 40 bytes of a PictureData prop are
        ' not a BITMAPINFOHEADER structure then we will find
        ' a ClipBoard Format structure of 8 Bytes in length
        ' signifying whether a Metafile or Enhanced Metafile is present.
        '
        ' So the first 4 bytes tell us the format of the data.
        ' The next 4 bytes point to handle for a Memory Metafile.
        ' This is not needed for our purposes.

        Select Case picData(0)
            Case 40
                ' This is a straight DIB.
                Call saveAsMetafile(picData, ctrlname, ".bmp")
            Case CF_ENHMETAFILE
                ' New Enhanced Metafile(EMF)
                Call saveAsMetafile(picData, ctrlname, ".emf")
            Case CF_METAFILEPICT
                ' Old Metafile format(WMF)
        End Select
    End Sub

    Private Sub saveAsMetafile(ByVal PicData As Byte(), ByVal ctrlname As String, ByVal extension As String)
        Dim fname As String = Environ("Temp") + "\" + ctrlname + extension 'The name of the file to save the picture to
        Dim lngRet As Long

        Dim newsize As Integer = PicData.Length - 1
        Dim cArray(newsize - 8) As Byte

        ' Copy to our array
        For lngRet = 8 To UBound(cArray)
            cArray(lngRet - 8) = PicData(lngRet)
        Next

        System.IO.File.WriteAllBytes(fname, cArray)

    End Sub

End Module