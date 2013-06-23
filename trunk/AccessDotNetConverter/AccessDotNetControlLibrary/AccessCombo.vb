
Public Class AccessCombo


    ''' <summary>
    ''' Allow for an SQL string to be determined as the datasource
    ''' </summary>
    Private _RowSource As String

    ''' <summary>
    ''' Allow row source type specification
    ''' </summary>
    Public Property RowSourceType As String

    ''' <summary>
    ''' Allow for an SQL string to be determined as the datasource
    ''' </summary>
    Public Property RowSource() As String
        Get
            Return _RowSource
        End Get
        Set(value As String)
            _RowSource = value
        End Set

    End Property

End Class
