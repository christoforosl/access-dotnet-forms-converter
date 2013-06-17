Public Interface INamingHandler

    Function getDotNetname(accessName As String) As String

End Interface

Public Class DefaultNameHandler
    Implements INamingHandler

    Public Function getDotNetname(cname As String) As String Implements INamingHandler.getDotNetname

        Dim i As Integer
        Dim ret As String = String.Empty

        Dim arr As String() = Split(cname, "_")
        For i = 0 To UBound(arr)
            ret = ret & Mid$(arr(i), 1, 1).ToUpper & Mid$(arr(i), 2)
        Next

        If ret.ToLower = "name" Then
            ret = "__" & cname
        End If

        Return ret
    End Function
End Class

''' <summary>
''' Simply return the Access Control name and use that as a .NET name
''' </summary>
Public Class NoConversionNameHandler
    Implements INamingHandler

    Public Function getDotNetname(ByVal cname As String) As String Implements INamingHandler.getDotNetname
        Return cname
    End Function
End Class