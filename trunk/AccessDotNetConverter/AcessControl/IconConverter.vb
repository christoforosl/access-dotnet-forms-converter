Imports System.IO
Imports System.Text
Imports System.Runtime.InteropServices


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

Public Module imagetest
    Private Structure BITMAPFILEHEADER
        Public bfType As Integer
        Public bfSize As Long
        Public bfReserved1 As Integer
        Public bfReserved2 As Integer
        Public bfOffBits As Long
    End Structure

    Private Structure BITMAPINFOHEADER '40 bytes
        Public biSize As Long
        Public biWidth As Long
        Public biHeight As Long
        Public biPlanes As Integer
        Public biBitCount As Integer
        Public biCompression As Long
        Public biSizeImage As Long
        Public biXPelsPerMeter As Long
        Public biYPelsPerMeter As Long
        Public biClrUsed As Long
        Public biClrImportant As Long
    End Structure

    Private Const CF_ENHMETAFILE = 14

    Private Declare Sub CopyMemory1 Lib "kernel32" Alias "RtlMoveMemory" ( _
       lpvDest As BITMAPINFOHEADER, lpvSource As Byte, ByVal cbCopy As Long)

    Private Declare Sub CopyMemory2 Lib "kernel32" Alias "RtlMoveMemory" ( _
       lpvDest As Byte, lpvSource As Byte, ByVal cbCopy As Long)

    Public Sub SavePicture712(bPicData As Byte())

        Dim bih As BITMAPINFOHEADER
        Dim bfh As BITMAPFILEHEADER
        Dim nFile As Integer

        'CopyMemory1(bih, bPicData(0), Len(bih))
        Dim ptr As New System.IntPtr
        'ptr = Marshal.AllocHGlobal(Marshal.SizeOf(bih))
        Call Marshal.Copy(bPicData, 0, ptr, 1)

        If bih.biSize = Len(bih) Then 'DIB
            bfh.bfType = Asc("B") + Asc("M") * 256
            bfh.bfSize = Len(bfh) + Len(bih) + bih.biSizeImage
            If (bih.biClrUsed = 0) And (bih.biBitCount <= 8) Then _
               bih.biClrUsed = 2& ^ bih.biBitCount
            bfh.bfOffBits = Len(bfh) + Len(bih) + bih.biClrUsed * 4
            nFile = FreeFile()
            FileOpen("tmp.bmp", nFile, OpenMode.Binary, OpenAccess.ReadWrite)
            FileClose(nFile)
            FileOpen("tmp.bmp", nFile, OpenMode.Binary, OpenAccess.Write)
            FilePut(nFile, bfh)
            FilePut(nFile, bPicData)
            FileClose(nFile)

        ElseIf bih.biSize = CF_ENHMETAFILE Then 'EMF
            CopyMemory2(bPicData(0), bPicData(8), UBound(bPicData) - 7)
            ReDim Preserve bPicData(0 To UBound(bPicData) - 8)
            nFile = FreeFile()
            FileOpen("tmp.emf", nFile, OpenMode.Binary, OpenAccess.ReadWrite)
            FileClose(nFile)
            FileOpen("tmp.emf", nFile, OpenMode.Binary, OpenAccess.Write)
            FilePut(nFile, bPicData)
            FileClose(nFile)
        Else
            Throw New ApplicationException("Invalid Format")
            Exit Sub
        End If

    End Sub

End Module